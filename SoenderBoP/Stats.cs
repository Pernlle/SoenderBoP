using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string sqlcom = $"SELECT email AS 'Email', rId AS 'Reservations ID', mLNr AS 'Løbenummer', dStart AS 'Start dato', dSlut AS 'Slut dato' FROM Medlem, Reserveret WHERE mLNr = rLNr;"; // lId IS NOT NULL
            showStatsDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DataGridView DGV = showStatsDGV;
            GetDGVStyle.GetStyle(DGV);
            showStatsDGV.RowHeadersVisible = false;
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
            string sqlcom = $"SELECT rId AS 'Reservations ID', mLNr AS 'Løbenummer', dStart AS 'Start dato', dSlut AS 'Slut dato', email AS 'Email' FROM Medlem, Reserveret WHERE email = '{medlem}' AND mLNr = rLNr;";

            // sqlcom bliver sendt over i GetDataSource, som ligger i FillDataSource, som så vises i DGV
            showStatsDGV.DataSource = FillDataSource.GetDataSource(sqlcom); 
        }
        

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

        private void printStatsBTN_Click(object sender, EventArgs e)
        {
            string medlem = statsCBX.Text;

            string writerName = $"Resourceforbrug_{medlem}";
            string[] headersarr = new string[] {"Ressource ID", "Løbenummer", "Startdato", "Slutdato", "Email" };
            DataGridView dgv = showStatsDGV;

            Print.PrintIt(dgv, writerName, headersarr);
        }

        private void statsCBX_Click(object sender, EventArgs e)
        {
            string sqlcom = "SELECT email FROM Medlem";
            statsCBX.DataSource = FillDataSource.GetDataSource(sqlcom);
        }       
    }
}