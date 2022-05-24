using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoenderBoP
{
    public partial class Lease : Form
    {
        string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";

        public Lease()
        {
            InitializeComponent();
            string sqlcom = $"SELECT lNr AS 'Løbenummer', adr AS 'Adresse',  lDato AS 'Indflytter', fNavn AS 'Fornavn', eNavn AS 'Efternavn', email AS 'Email', mId AS 'ID' FROM Lejekontrakt, Bolig, Medlem WHERE lNr = mLNr AND lNr = bLNr";
            leaseDGV.DataSource = FillDataSource.GetDataSource(sqlcom);

            DataGridView DGV = leaseDGV;
            GetDGVStyle.GetStyle(DGV);
            leaseDGV.RowHeadersVisible = false;
        }

        private void CreateLease_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);

            string mId = mIdTxt.Text; //Få den til at ændre det til mmid når email er valgt :)
            string bId = bIdTxt.Text; // få den til at vælge bid når adresse er valgt :)
            string dato = leaseDTP.Value.ToString("dd-MM-yyyy");

            string insertInto = "Lejekontrakt";
            object[] data = { dato };
            //Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
            string add = "lDato";
            // lav en values add for hver value? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            string values = "@lDato";

            CRUD.Create(insertInto, add, values, data);

            //Sql Command
            string sqlCom = $"SELECT TOP 1 * FROM Lejekontrakt ORDER BY lNr DESC";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            try
            {
                conn.Open();
                var loebeNr = (Int32)cmd.ExecuteScalar();
                //Test om de rigtige værdier kan puttes i db
                MessageBox.Show($"Værdier: Id: {mId} | Løbenummer: {loebeNr} | date: {dato}");

                sqlCom = $"UPDATE Medlem SET {loebeNr} WHERE mId = {mId}";
                cmd.Parameters.AddWithValue("@mLNr", loebeNr);
                cmd.ExecuteNonQuery();

                sqlCom = $"UPDATE Bolig SET {loebeNr} WHERE bId = {bId}";
                cmd.Parameters.AddWithValue("@bLNr", loebeNr);
                cmd.ExecuteNonQuery();
                
                sqlCom = $"DELETE vMid FROM Venteliste WHERE mId = {mId}";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }
            
        }

        private void emailCBX_Click(object sender, EventArgs e)
        {
            string sqlcom = "SELECT email FROM Medlem";
            emailCBX.DataSource = FillDataSource.GetDataSource(sqlcom);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.leaseDGV.Refresh();
            this.leaseDGV.Update();
        }

        private void Lease_Load(object sender, EventArgs e)
        {

        }

        private void leaseAdresseCBX_Click(object sender, EventArgs e)
        {
            string sqlcom = "SELECT adr FROM Bolig";
            leaseAdresseCBX.DataSource = FillDataSource.GetDataSource(sqlcom);
        }
    }
}
