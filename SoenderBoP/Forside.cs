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
    public partial class Forside : Form
    {
        public Forside()
        {
            InitializeComponent();
        }

        private void Forside_Load(object sender, EventArgs e)
        {
            manuPanel.Controls.Clear();
            Menu frm = new Menu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.manuPanel.Controls.Add(frm);
            frm.Show();

            sloganPanel.Controls.Clear();
            Slogan formme = new Slogan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formme.FormBorderStyle = FormBorderStyle.None;
            this.sloganPanel.Controls.Add(formme);
            formme.Show();
        }
    }
}
