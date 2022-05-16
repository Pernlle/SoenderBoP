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
            // TODO: This line of code loads data into the 'soenderbodbDataSet.Medlem' table. You can move, or remove it, as needed.
            this.medlemTableAdapter.Fill(this.soenderbodbDataSet.Medlem);
            // TODO: This line of code loads data into the 'soenderbodbDataSet.Ressource' table. You can move, or remove it, as needed.
            this.ressourceTableAdapter.Fill(this.soenderbodbDataSet.Ressource);
            // TODO: This line of code loads data into the 'soenderbodbDataSet.Reserveret' table. You can move, or remove it, as needed.
            this.reserveretTableAdapter.Fill(this.soenderbodbDataSet.Reserveret);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connect to the database
            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=Ju7XZj_8pI2_";
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd;

            //create a command
            string sqlcom = "SELECT loebeNr FROM Reserveret";


            try
            {
                conn.Open();
                cmd = new SqlCommand(sqlcom, conn);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                conn.Close();

                //Display data on the page
                label3.Text = "Antal af reserverert = " + rows_count.ToString();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}