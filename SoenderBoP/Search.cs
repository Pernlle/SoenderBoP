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

        private DataGridView SearchDGV = new DataGridView();

        public Search()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int minKvm = Convert.ToInt32(minKvmBox.Text);
            int maxKvm = Convert.ToInt32(maxKvmBox.Text);
            double minPris = Convert.ToDouble(minPrisBox.Text);
            double maxPris = Convert.ToDouble(maxPrisBox.Text);

            MessageBox.Show(Convert.ToString(minKvm));

            if (minKvm > maxKvm)
            {
                SearchDGV.DataSource = this.PopulateDataGridViewKvm(strconn, minKvm, maxKvm);

            }
            else MessageBox.Show("pris fejl");

            if (minPris > maxPris)
            {
                SearchDGV.DataSource = this.PopulateDataGridViewPris(strconn, minPris, maxPris);

            }
            else MessageBox.Show("kvm fejl");

        }

        private void Search_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            SearchDGV.DataSource = this.PopulateDataGridView(strconn);
        }

        private void SetupDataGridView()
        {
            searchPanel.Controls.Add(SearchDGV);

            //Color.FromKnownColor(KnownColor.IndianRed)

            SearchDGV.BackgroundColor = Color.FromKnownColor(KnownColor.IndianRed); // baggrunden bag ved dgv
            SearchDGV.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.IndianRed); //celle farve :)

            SearchDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            SearchDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.IndianRed);
            SearchDGV.ColumnHeadersDefaultCellStyle.Font = new Font(SearchDGV.Font, FontStyle.Regular);
            SearchDGV.Name = "SearchDGV";
            SearchDGV.Location = new Point(8, 8);
            SearchDGV.Size = new Size(500, 250);
            SearchDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            SearchDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            SearchDGV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            SearchDGV.GridColor = Color.Black;
            SearchDGV.RowHeadersVisible = false;

            SearchDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchDGV.MultiSelect = false;
            SearchDGV.Dock = DockStyle.Fill;
        }

        private DataTable PopulateDataGridView(string strconn)
        {

            string query = "SELECT bId AS 'Id', mndPris AS 'Pris pr måned', adr AS 'Adresse', kvm AS 'Kvm', bType AS 'Type af bolig', loebeNr AS 'Løbenummer' FROM Bolig";
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
        }
        private DataTable PopulateDataGridViewPris(string strconn, double minPris, double maxPris)
        {

            string query = "SELECT bId AS 'Id', mndPris AS 'Pris pr måned', adr AS 'Adresse', kvm AS 'Kvm', bType AS 'Type af bolig', loebeNr AS 'Løbenummer' FROM Bolig" +
                $"Where mndPris > {minPris} AND mndPris < {maxPris} ";
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
        }

        private DataTable PopulateDataGridViewKvm(string strconn, int minKvm, int maxKvm)
        {

            string query = "SELECT bId AS 'Id', mndPris AS 'Pris pr måned', adr AS 'Adresse', kvm AS 'Kvm', bType AS 'Type af bolig', loebeNr AS 'Løbenummer' FROM Bolig" +
                $"Where kvm > {minKvm} AND kvm < {maxKvm}";
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
        }

    }
}
