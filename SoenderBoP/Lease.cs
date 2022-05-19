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
    public partial class Lease : Form
    {
        public Lease()
        {
            InitializeComponent();
            string sqlcom = "SELECT  loebeNr 'Løbenummer', indflytter AS 'Indflytter', fNavn AS 'Fornavn', eNavn AS 'Efternavn', email AS 'Email', mId AS 'ID' FROM Medlem, Lejekontrakt WHERE loebeNr = lNr";
            leaseDGV.DataSource = FillDataSource.GetDataSource(sqlcom);

            
        }

        private void CreateLease_Click(object sender, EventArgs e)
        {
            string theDate = leaseDTP.Value.ToString("dd-MM-yyyy");
        }
    }
}
