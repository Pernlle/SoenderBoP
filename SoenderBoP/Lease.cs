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
            string sqlcom = "SELECT mId AS 'ID', fNavn AS 'Fornavn', eNavn AS 'Efternavn', email AS 'Email', loebeNr 'Løbenummer', indflytter AS 'Indflytter' FROM Medlem, Lejekontrakt WHERE loebeNr = lNr";

        }

        private void CreateLease_Click(object sender, EventArgs e)
        {

        }
    }
}
