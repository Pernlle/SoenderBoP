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
        public Lease()
        {
            InitializeComponent();
            string sqlcom = $"SELECT loebeNr AS 'Løbenummer', adr AS 'Adresse',  indflytter AS 'Indflytter', fNavn AS 'Fornavn', eNavn AS 'Efternavn', email AS 'Email', mId AS 'ID' FROM Medlem, Lejekontrakt, Bolig, BoligType WHERE loebeNr = lNr";
            leaseDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DataGridView DGV = leaseDGV;
            GetDGVStyle.GetStyle(DGV);
            leaseDGV.RowHeadersVisible = false;


        }

        private void CreateLease_Click(object sender, EventArgs e)
        {
            string mId = this.mIdTxt.Text;
            string bId = this.bIdTxt.Text;
            string dato = leaseDTP.Value.ToString("dd-MM-yyyy");
            

            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";

            //Sql Connection
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            ////Sql sætning
            string sqlCom = $"INSERT INTO Lejekontrakt VALUES ({dato});";
            
            //Sql Command
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            cmd.ExecuteNonQuery();

            sqlCom = $"SELECT TOP 1 * FROM Lejekontrakt ORDER BY loebeNr DESC";

            //EFTER ny lejekontrakt oprettes henter vi seneste løbeNr.

            var loebeNr = (Int32)cmd.ExecuteScalar();

            

            //Test om de rigtige værdier kan puttes i db
            MessageBox.Show($"Værdier: Id: {mId} | Løbenummer: {loebeNr} | date: {dato}");


            //Opdatere medlem med loebeNr fra seneste Lejekontrakt (den der oprettes ovenfor)
            sqlCom = $"UPDATE Medlem SET {loebeNr} WHERE mId = {mId}";
            SqlCommand cmd2 = new SqlCommand(sqlCom, conn);
            cmd2.Parameters.AddWithValue("@lNr", loebeNr);

            //Opdatere medlem med loebeNr fra seneste Lejekontrakt (den der oprettes ovenfor)
            sqlCom = $"UPDATE Bolig SET {loebeNr} WHERE bId = {bId}";
            SqlCommand cmd3 = new SqlCommand(sqlCom, conn);
            cmd3.Parameters.AddWithValue("@lNr", loebeNr);

            // Fjerner medlemmet fra Venteliste(n/erne) denne er på
            sqlCom = $"DELETE {loebeNr} FROM Venteliste WHERE medlemId = {mId}";
            SqlCommand cmd4 = new SqlCommand(sqlCom, conn);


            conn.Close();

            try
            {
                conn.Open();
                
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show($"oprettet");
                //MessageBox.Show(sqlCom);
                this.leaseDGV.Refresh();
                this.leaseDGV.Update();
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
    }
}
