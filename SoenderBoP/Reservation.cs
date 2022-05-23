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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            string sqlcom = "SELECT rId AS 'ID', rType AS 'Ressource', rNr AS 'Nr.' FROM Ressource";
            rDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DataGridView DGV = rDGV;
            GetDGVStyle.GetStyle(DGV);
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";
            string loebeNr = this.loebeNr.Text;
            string rId = this.rId.Text;

            string daStartDag = dStartDag.Text;
            string daStartMaaned = dStartMaaned.Text;
            string daStartAar = dStartAar.Text;
            string daStartTime = dStartTime.Text;
            string daStartMinut = dStartMinut.Text;

            string daSlutDag = dSlutDag.Text;
            string daSlutMaaned = dSlutMaaned.Text;
            string daSlutAar = dSlutAar.Text;
            string daSlutTime = dSlutTime.Text;
            string daSlutMinut = dSlutMinut.Text;

            //if (daStartDag.Length == 2 && daStartMaaned.Length == 2 && daStartTime.Length == 2 && daStartMinut.Length == 2 && daSlutDag.Length == 2 && daSlutMaaned.Length == 2 && daSlutTime.Length == 2 && daSlutMinut.Length == 2 && daStartAar.Length == 4 && daSlutAar.Length == 4)
            //{

                string dStart = daStartDag + "-" + daStartMaaned + "-" + daStartAar + "-" + daStartTime + ":" + daStartMinut;
                string dSlut = daSlutDag + "-" + daSlutMaaned + "-" + daSlutAar + "-" + daSlutTime + ":" + daSlutMinut;

                SqlConnection conn = new SqlConnection(strconn);

                string sqlCom = "INSERT INTO Reserveret(rLNr,rId,dStart,dSlut) VALUES (@rLNr, @rId, @dStart, @dSlut);";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.AddWithValue("@rLNr", loebeNr);
                cmd.Parameters.AddWithValue("@rId", rId);
                cmd.Parameters.AddWithValue("@dStart", dStart);
                cmd.Parameters.AddWithValue("@dSlut", dSlut);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Reserveret");
                //MessageBox.Show(sqlCom);
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            
        }
    }
}
