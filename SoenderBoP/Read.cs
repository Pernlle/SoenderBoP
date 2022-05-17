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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
        }

        private void Read_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soenderbodbDataSet1.Reserveret' table. You can move, or remove it, as needed.
            this.reserveretTableAdapter.Fill(this.soenderbodbDataSet1.Reserveret);
            // TODO: This line of code loads data into the 'soenderbodbDataSet.Medlem' table. You can move, or remove it, as needed.
            this.medlemTableAdapter.Fill(this.soenderbodbDataSet.Medlem);
            // TODO: This line of code loads data into the 'soenderbodbDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.soenderbodbDataSet.Bolig);

        }
    }
}
