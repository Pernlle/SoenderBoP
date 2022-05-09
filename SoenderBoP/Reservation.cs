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
            string loebeNr = loebeNrMTxt.Text;
            string rId = rIdMTxt.Text;
            string dStart = Convert.ToString(datoStartMTxt.Text);
            string dSlut = Convert.ToString(datoSlutMTxt.Text);

            SqlConnection conn = new SqlConnection(strconn);

            string sqlCom = "INSERT INTO Reserveret(loebeNr,rId,dStart,dSlut) VALUES (@loebeNr, @rId, @dStart, @dSlut);";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            cmd.Parameters.Add("@loebeNr", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@loebeNr"].Value = Convert.ToString(loebeNr);
            cmd.Parameters.Add("@rId", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@rId"].Value = Convert.ToString(rId);
            cmd.Parameters.Add("@dStart", System.Data.SqlDbType.Date);
            cmd.Parameters["@dStart"].Value = Convert.ToString(dStart);
            cmd.Parameters.Add("@dSlut", System.Data.SqlDbType.Date);
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
