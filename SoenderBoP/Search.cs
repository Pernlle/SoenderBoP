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
        private DataGridView SearchDGV = new DataGridView();

        public Search()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Pris søg klik

            int minPris = Convert.ToInt32(minPrisBox.Text);
            int maxPris = Convert.ToInt32(maxPrisBox.Text);


            if (minPris < maxPris)
            {
                SearchDGV.Controls.Clear();
                string sqlcom = "SELECT bId AS 'ID', mndPris AS 'Pris pr måned', adr AS 'Adresse', kvm AS 'Kvm', bType AS 'Type af bolig', bLNr AS 'Løbenummer' FROM Bolig " +
                $"WHERE mndPris > {minPris} AND mndPris < {maxPris}; ";
                SearchDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            }
            else MessageBox.Show("kvm fejl");
        }

        private void Search_Load(object sender, EventArgs e)
        {
            
        }

        private void searchKvmBtn_Click(object sender, EventArgs e)
        {
            // kvm søg klik
            int minKvm = Convert.ToInt32(minKvmBox.Text);
            int maxKvm = Convert.ToInt32(maxKvmBox.Text);
            
            MessageBox.Show(Convert.ToString(minKvm));

            if (minKvm < maxKvm)
            {
                SearchDGV.Controls.Clear();

                string sqlcom = "SELECT bId AS 'ID', mndPris AS 'Pris pr måned', adr AS 'Adresse', kvm AS 'Kvm', bType AS 'Type af bolig', bLNr AS 'Løbenummer' FROM Bolig " +
                $"WHERE kvm > {minKvm} AND kvm < {maxKvm};";
                SearchDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            }
            else MessageBox.Show("Pris fejl");
        }

        private void SetupDataGridView()
        {
            searchPanel.Controls.Add(SearchDGV);
            DataGridView DGV = SearchDGV;
            GetDGVStyle.GetStyle(DGV);
        }

        private void sallBTN_Click(object sender, EventArgs e)
        {
            SetupDataGridView();
            string sqlcom = "SELECT bId AS 'ID', mndPris AS 'Pris pr måned', adr AS 'Adresse', kvm AS 'Kvm', bType AS 'Type af bolig', bLNr AS 'Løbenummer' FROM Bolig";
            SearchDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
        }

        private void saBTN_Click(object sender, EventArgs e)
        {
            SetupDataGridView();
            string sqlcom = "SELECT * FROM Bolig WHERE bLNr IS NULL";
            SearchDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
        }
    }
}
