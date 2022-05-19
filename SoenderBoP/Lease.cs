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
            string sqlcom = $"SELECT loebeNr 'Løbenummer', indflytter AS 'Indflytter', fNavn AS 'Fornavn', eNavn AS 'Efternavn', email AS 'Email', mId AS 'ID' FROM Medlem, Lejekontrakt WHERE loebeNr = lNr;";
            leaseDGV.DataSource = FillDataSource.GetDataSource(sqlcom);

            
        }

        private void CreateLease_Click(object sender, EventArgs e)
        {
            string theDate = leaseDTP.Value.ToString("dd-MM-yyyy");

            
            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";
            //Sql Connection
            SqlConnection conn = new SqlConnection(strconn);
            //Sql sætning
            //string sqlCom = $"INSERT INTO Lejekontrakt VALUES ({theDate});";
            ////Sql Command
            //SqlCommand cmd = new SqlCommand(sqlCom, conn);

            string sql = $"SELECT TOP 1 * FROM Lejekontrakt ORDER BY loebeNr DESC";
            
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
             
            var result = (Int32)cmd.ExecuteScalar();
             
            MessageBox.Show($"{result} og date: { theDate}");
            


            //try
            //{
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show($"oprettet");
            //    //MessageBox.Show(sqlCom);
            //}
            //catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            //finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }
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
