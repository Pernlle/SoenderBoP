using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SoenderBoP
{
    public partial class Forside : Form
    {
        private readonly Random _rnd = new Random();
        private readonly List<string> _slogans = new List<string> { "SønderBo er søndme god", "Er det sønder god, er det Sønderbo", "Din tryghed kan vi bære, i SønderBo kan du være", "Mangler du en bolig? I Sønderbo kan du tage det helt rolig’", "Vores ventelister er helt tomme! Vent…",  "Foreningen SønderBo, forener vi forenet i forening", "Det sønder, sønder fedt, jeg melder mig om lidt" };
        private readonly Thread _thread;
        public Forside()
        {
            InitializeComponent();
            _thread = new Thread(UpdateSlogan);
            
            _thread.Start();
        }

        private void UpdateSlogan()
        {
            while (true)
            {
                if (this.IsHandleCreated)
                {
                    var slogan = _slogans[_rnd.Next(_slogans.Count)];
                    sloganLabel.BeginInvoke(new Action(() => sloganLabel.Text = slogan));
                }


                Thread.Sleep(TimeSpan.FromMinutes(3));
            }
        }
        private void Forside_Load(object sender, EventArgs e)
        {
           


            //sloganPanel.Controls.Clear();
            //Slogan formme = new Slogan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //formme.FormBorderStyle = FormBorderStyle.None;
            //this.sloganPanel.Controls.Add(formme);
            //formme.Show();
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
            frm.WindowState= FormWindowState.Maximized;

            this.panel1.Controls.Add(frm);

            frm.Show();
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Stats frm = new Stats() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();
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

        private void Forside_FormClosing(object sender, FormClosingEventArgs e)
        {
            _thread.Abort();
        }

        private void lboligBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Available frm = new Available() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;

            this.panel1.Controls.Add(frm);

            frm.Show();
        }
    }
}
