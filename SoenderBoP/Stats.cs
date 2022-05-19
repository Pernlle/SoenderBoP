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
            string sqlcom = "SELECT email FROM Medlem";
            statsCBX.DataSource = FillDataSource.GetDataSource(sqlcom);
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
            string sqlcom = $"SELECT email AS 'Email', rId AS 'Reservations ID', lId AS 'Løbenummer', dStart AS 'Start dato', dSlut AS 'Slut dato' FROM Medlem, Reserveret WHERE email = '{medlem}';";

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

            TextWriter writer = new StreamWriter($@"..\..\..\SoenderBoP\Resources\Resourceforbrug_{medlem}.Txt");
            for (int i = 0; i < showStatsDGV.Rows.Count - 1; i++) // rows
            {
                for (int j = 0; j < showStatsDGV.Columns.Count; j++) // columns
                {
                    if (j == showStatsDGV.Columns.Count - 1) // if last column
                    {
                        writer.WriteLine("\t" + showStatsDGV.Rows[i].Cells[j].Value.ToString());
                    }
                    else
                        writer.Write("\t" + showStatsDGV.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
            }
            writer.Close();
            MessageBox.Show("Exported");
        }
    }
}