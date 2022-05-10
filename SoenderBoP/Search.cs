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
            // TODO: This line of code loads data into the 'soenderbodbDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.soenderbodbDataSet.Bolig);

        }
    }
}
