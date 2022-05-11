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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();

        }

        private void Stats_Load(object sender, EventArgs e)
        {
            //connect to the database
            string str = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=Ju7XZj_8pI2_";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "SELECT loebeNr FROM Reserveret";


            try
            {
                con.Open();
                label2.ForeColor = Color.Green;
                label2.Text = "Database Sucessfully Connected!!";

                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                label3.Text = "Antal af reserverert = " + rows_count.ToString();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
