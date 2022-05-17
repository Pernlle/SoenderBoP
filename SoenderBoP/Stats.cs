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
            // udtrækkes en statistik, der viser hvilke typer af ressourcer de enkelte beboere har reserveret på en bestemt dato.
            // Der  skal være en opsummering, der viser hvor mange der i alt har reserveret på hver at de 10 muligheder for  reservering.
            // Statistikken skal kunne udskrives på en text-fil kaldet Resourceforbrug.txt.

            string medlem = comboBox1.Text; 

            //Få databasen til at omskrive emailen til loebenr så sql kan vise medlemets reservationer.. Eller
            // Eller lav en select som viser både elementer fra medlem og reserveret.

            //connect to the database
            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd;

            //create a command 
            string sqlcom = $"SELECT rId, loebeNr, dStart, dSlut FROM Reserveret WHERE loebeNr = {medlem}";

            try
            {
                conn.Open();
                cmd = new SqlCommand(sqlcom, conn);

                cmd.ExecuteReader();

                //cmd.Dispose(); //release both managed and unmanaged resources

                using (SqlDataReader sqlReader = cmd.ExecuteReader())
                {
                    if (sqlReader.Read())
                    {
                        statsRichTextBox.Text = sqlReader.GetString(sqlReader.GetOrdinal("rId, loebeNr, dStart, dSlut"));
                    }
                }
                //Display data on the page
                
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}