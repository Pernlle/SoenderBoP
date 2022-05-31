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
            string sqlcom = $"SELECT rType AS 'Ressource', rNr AS 'Nr', dStart AS 'Start dato', dSlut AS 'Slut dato', mLNr AS 'Løbenummer', email AS 'Email' FROM Reserveret, Ressource, Medlem WHERE rLNr = mLNr AND rRId = rId"; // lId IS NOT NULL
            FillDataSource.SetUpDGV(showStatsDGV, sqlcom);
        }

        // ComboBox = vælg medlem 
        private void statsCBX_Click(object sender, EventArgs e)
        {
            string sqlcom = "SELECT email FROM Medlem WHERE mLNr IS NOT NULL";
            statsCBX.DataSource = FillDataSource.GetDataSource(sqlcom);
        }

        // Knap = Vis
        private void cStatBtn_Click(object sender, EventArgs e)
        {
            // udtrækkes en statistik, der viser hvilke typer af ressourcer de enkelte beboere har reserveret på en bestemt dato.
            // Der skal være en opsummering, der viser hvor mange der i alt har reserveret på hver at de 10 muligheder for  reservering.
            // Statistikken skal kunne udskrives på en text-fil kaldet Resourceforbrug.txt.

            string medlem = statsCBX.Text;
            string sqlcom = $"SELECT rType AS 'Ressource', rNr AS 'Nr', dStart AS 'Start dato', dSlut AS 'Slut dato', mLNr AS 'Løbenummer', email AS 'Email' FROM Reserveret, Ressource, Medlem WHERE rLNr = mLNr AND rRId = rId AND email = '{medlem}'";

            // sqlcom bliver sendt over i GetDataSource, som ligger i FillDataSource, som så vises i DGV
            showStatsDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
        }
        
        // Knap = Vis alle
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            string sqlcom = $"SELECT rType AS 'Ressource', rNr AS 'Nr', dStart AS 'Start dato', dSlut AS 'Slut dato', mLNr AS 'Løbenummer' FROM Reserveret, Ressource, Medlem WHERE rLNr = mLNr AND rRId = rId"; // lNr IS NOT NULL
            FillDataSource.SetUpDGV(showStatsDGV, sqlcom);
            statsCBX.Items.Clear();       
        }

        // Knap = Print stats
        private void printStatsBTN_Click(object sender, EventArgs e)
        {
            if (statsCBX.Text == "")
            {
                string medlem = statsCBX.Text;
                string title = $"Reservationer";
                string writerName = $"Resourceforbrug_Alle";
                string[] headersarr = new string[] { "Ressource", "Nr", "Løbenummer", "Startdato", "Slutdato" };
                DataGridView dgv = showStatsDGV;
                Print.PrintIt(dgv, writerName, headersarr, title);
            }
            else
            {
                string medlem = statsCBX.Text;
                string title = $"{medlem}";
                string writerName = $"Resourceforbrug_{medlem}";
                string[] headersarr = new string[] { "Ressource", "Nr", "Løbenummer", "Startdato", "Slutdato" };
                DataGridView dgv = showStatsDGV;
                Print.PrintIt(dgv, writerName, headersarr, title);
            }
        }

        // Ubrugt kode
        private void label1_Click(object sender, EventArgs e) {}
        private void label2_Click(object sender, EventArgs e) {}
        private void label5_Click(object sender, EventArgs e) {}
        private void Stats_Load(object sender, EventArgs e) {}

    }
}