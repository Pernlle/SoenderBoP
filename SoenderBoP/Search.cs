using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoenderBoP
{
    public partial class Search : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView SearchDGV = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        public Search()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int minKvm = Convert.ToInt32(minKvmBox.Text);
            int maxKvm = Convert.ToInt32(maxKvmBox.Text);
            int minPris = Convert.ToInt32(minPrisBox.Text);
            int maxPris = Convert.ToInt32(maxPrisBox.Text);

            if (minKvm > maxKvm)
            {
                // vis de boligere fra minKvm til maxKvm
                
            }

            if (minPris > maxPris)
            {
                // vis de boligere fra minPris til maxPris

            }

        }

        private void Search_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void SetupDataGridView()
        {
            searchPanel.Controls.Add(SearchDGV);


            SearchDGV.ColumnCount = 5;

            SearchDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            SearchDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SearchDGV.ColumnHeadersDefaultCellStyle.Font =
                new Font(SearchDGV.Font, FontStyle.Bold);

            SearchDGV.Name = "SearchDGV";
            SearchDGV.Location = new Point(8, 8);
            SearchDGV.Size = new Size(500, 250);
            SearchDGV.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            SearchDGV.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            SearchDGV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            SearchDGV.GridColor = Color.Black;
            SearchDGV.RowHeadersVisible = false;

            SearchDGV.Columns[0].Name = "Release Date";
            SearchDGV.Columns[1].Name = "Track";
            SearchDGV.Columns[2].Name = "Title";
            SearchDGV.Columns[3].Name = "Artist";
            SearchDGV.Columns[4].Name = "Album";
            SearchDGV.Columns[4].DefaultCellStyle.Font =
                new Font(SearchDGV.DefaultCellStyle.Font, FontStyle.Italic);

            SearchDGV.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            SearchDGV.MultiSelect = false;
            SearchDGV.Dock = DockStyle.Fill;
        }

        private void PopulateDataGridView()
        {

            string[] row0 = { "11/22/1968", "29", "Revolution 9",
            "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
            "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
            "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
            "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
            "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
            "Scatterbrain. (As Dead As Leaves.)",
            "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

            SearchDGV.Rows.Add(row0);
            SearchDGV.Rows.Add(row1);
            SearchDGV.Rows.Add(row2);
            SearchDGV.Rows.Add(row3);
            SearchDGV.Rows.Add(row4);
            SearchDGV.Rows.Add(row5);
            SearchDGV.Rows.Add(row6);

            SearchDGV.Columns[0].DisplayIndex = 3;
            SearchDGV.Columns[1].DisplayIndex = 4;
            SearchDGV.Columns[2].DisplayIndex = 0;
            SearchDGV.Columns[3].DisplayIndex = 1;
            SearchDGV.Columns[4].DisplayIndex = 2;
        }
    }
}
