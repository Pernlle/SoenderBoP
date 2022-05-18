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
        string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";

        public Stats()
        {
            InitializeComponent();

        }

        private void Stats_Load(object sender, EventArgs e)
        {
            statsCBX.DataSource = GetStats();

        }
        private DataTable GetStats()
        {
            string sqlcom = "SELECT email FROM Medlem";
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                using (SqlCommand cmd = new SqlCommand(sqlcom, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // udtrækkes en statistik, der viser hvilke typer af ressourcer de enkelte beboere har reserveret på en bestemt dato.
            // Der  skal være en opsummering, der viser hvor mange der i alt har reserveret på hver at de 10 muligheder for  reservering.
            // Statistikken skal kunne udskrives på en text-fil kaldet Resourceforbrug.txt.

            string medlem = statsCBX.Text;

            showStatsDGV.DataSource = ShowStats(medlem);

            //Få databasen til at omskrive emailen til loebenr så sql kan vise medlemets reservationer.. Eller
            // Eller lav en select som viser både elementer fra medlem og reserveret.

            //connect to the database

            //create a command 



        }
        private DataTable ShowStats(string medlem)
        {
            string sqlcom = $"SELECT email AS 'Email', rId AS 'Reservations ID', lId AS 'Løbenummer', dStart AS 'Start dato', dSlut AS 'Slut dato' FROM Medlem, Reserveret WHERE email = '{medlem}';";

            try
            {
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlcom, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dtShow = new DataTable();
                            adapter.Fill(dtShow);
                            return dtShow;
                        }
                    }
                }
            }
            catch (Exception ecx) {  MessageBox.Show(ecx.ToString());}
            return null;

        }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }
        }
    }