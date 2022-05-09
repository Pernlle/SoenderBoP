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
            

            //hvilken tabel i db som skal arbejdes med
            string insertInto = "Reserveret";
            // lav en add for hver parameter? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            //Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
            string add = "loebeNr,rId,datoStart,datoSlut";
            // lav en values add for hver value? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            string values = "@loebeNr,@rId,@,@dStart, @dSlut";

            //Values fra tekstboxe:
            string loebeNr = loebeNrMTxt.Text;
            string rId = rIdMTxt.Text;
            string datoStart = Convert.ToString(datoStartMTxt.Text);
            string datoSlut = Convert.ToString(datoStartMTxt.Text);

            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=Ju7XZj_8pI2_";
            //Sql Connection
            SqlConnection conn = new SqlConnection(strconn);
            string sqlCom = $"INSERT INTO {insertInto}({add}) VALUES ({values});";
            //Sql Command
            SqlCommand cmd = new SqlCommand(sqlCom, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show($"{insertInto} oprettet");
                //MessageBox.Show(sqlCom);
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
        }
    }
}
