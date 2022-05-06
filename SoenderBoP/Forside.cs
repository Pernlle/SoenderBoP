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
            

            sloganPanel.Controls.Clear();
            Slogan formme = new Slogan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formme.FormBorderStyle = FormBorderStyle.None;
            this.sloganPanel.Controls.Add(formme);
            formme.Show();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Create frm = new Create() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Read frm = new Read() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Edit frm = new Edit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //Stats frm = new Stats() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //frm.FormBorderStyle = FormBorderStyle.None;

            //this.panel1.Controls.Add(frm);

            //frm.Show();
        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Reservation frm = new Reservation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();

        }

        private void waitListBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            WaitList frm = new WaitList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();
        }

        private void leaseBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Lease frm = new Lease() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Search frm = new Search() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Login frm = new Login() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();
        }


    }
}
