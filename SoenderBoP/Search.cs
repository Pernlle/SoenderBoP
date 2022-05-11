using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoenderBoP
{
    public partial class Search : Form
    {
        string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=Ju7XZj_8pI2_";

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
            SearchDGV.DataSource = this.PopulateDataGridView(strconn);
        }

        private void SetupDataGridView()
        {
            searchPanel.Controls.Add(SearchDGV);

            //SearchDGV.ColumnCount = 6;

            SearchDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            SearchDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SearchDGV.ColumnHeadersDefaultCellStyle.Font = new Font(SearchDGV.Font, FontStyle.Bold);

            SearchDGV.Name = "SearchDGV";
            SearchDGV.Location = new Point(8, 8);
            SearchDGV.Size = new Size(500, 250);
            SearchDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            SearchDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            SearchDGV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            SearchDGV.GridColor = Color.Black;
            SearchDGV.RowHeadersVisible = false;



            //SearchDGV.Columns[0].Name = "Id";
            //SearchDGV.Columns[1].Name = "Pris pr måned";
            //SearchDGV.Columns[2].Name = "Adresse";
            //SearchDGV.Columns[3].Name = "Kvm";
            //SearchDGV.Columns[4].Name = "Type af bolig";
            //SearchDGV.Columns[5].Name = "Løbenummer";
            //SearchDGV.Columns[5].DefaultCellStyle.Font = new Font(SearchDGV.DefaultCellStyle.Font, FontStyle.Italic);

            SearchDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchDGV.MultiSelect = false;
            SearchDGV.Dock = DockStyle.Fill;
        }

        private DataTable PopulateDataGridView(string strconn)
        {

            string query = "SELECT bId AS 'Id', mndPris AS 'Pris pr måned', adr AS 'Adresse', kvm AS 'Kvm', bType AS 'Type af bolig', loebeNr AS 'Løbenummer' FROM Bolig";
            //query += " WHERE ContactName LIKE '%' + @ContactName + '%'";
            //query += " OR @ContactName = ''";
            using (SqlConnection con = new SqlConnection(strconn))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
            //searchDGV.Rows.Add(row0);
            //searchDGV.Columns[0].DisplayIndex = 3;
        }
    }
}
