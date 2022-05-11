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

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=Ju7XZj_8pI2_";
            string loebeNr = this.loebe1Nr.Text;
            string rId = this.rId.Text;

            string daStartDag = dStartDag1.Text;
            string daStartMaaned = dStartMaaned1.Text;
            string daStartAar = dStartAar1.Text;
            string daStartTime = dS1tartTime.Text;
            string daStartMinut = ff.Text;

            string daSlutDag = dStartDag1.Text;
            string daSlutMaaned = dStartMaaned1.Text;
            string daSlutAar = dStartAar1.Text;
            string daSlutTime = dS1tartTime.Text;
            string daSlutMinut = ff.Text;

            string dStart = daStartDag + "-" + daStartMaaned + "-" + daStartAar + "-" + daStartTime + ":" + daStartMinut;
            string dSlut = daSlutDag + "-" + daSlutMaaned + "-" + daSlutAar + "-" + daSlutTime + ":" + daSlutMinut;

            SqlConnection conn = new SqlConnection(strconn);

            string sqlCom = "INSERT INTO Reserveret(loebeNr,rId,dStart,dSlut) VALUES (@loebeNr, @rId, @dStart, @dSlut);";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            cmd.Parameters.Add("@loebeNr", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@loebeNr"].Value = Convert.ToString(loebeNr);
            cmd.Parameters.Add("@rId", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@rId"].Value = Convert.ToString(rId);
            cmd.Parameters.Add("@dStart", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@dStart"].Value = Convert.ToString(dStart);
            cmd.Parameters.Add("@dSlut", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@dSlut"].Value = Convert.ToString(dSlut);

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
