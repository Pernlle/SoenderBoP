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
        private readonly Random rnd = new Random();
        private readonly List<string> slogans = new List<string> { "SønderBo er søndme god", "Er det sønder god, er det Sønderbo", "Din tryghed kan vi bære, i SønderBo kan du være", "Mangler du en bolig? I Sønderbo kan du tage det helt rolig’", "Vores ventelister er helt tomme! Vent…",  "Foreningen SønderBo, forener vi forenet i forening", "Det sønder, sønder fedt, jeg melder mig om lidt" };
        private readonly Thread thread;
        public Forside()
        {
            InitializeComponent();
            //lav en thread, som kører metoden Updateslogan
            thread = new Thread(UpdateSlogan);  
            //kør threaden
            thread.Start();   
            
            panel5.Hide();
        }
        //Updateslogan kører listen 'slogans' igennem randomly og skifter mellem dem hver 3. minut (som opgaven siger).
        private void UpdateSlogan()
        {
            while (true)
            {
                //hvis der er en forside /er forsiden åben - lav da ... slogan ...  (Dette betyder at hvis ikke forsiden er åbnet, skal den 
                //ikke lave det efterfølgende.) this. referer til selve forside forms'en. Det kræver derfor at forsiden kan åbne succesfuldt.
                if (this.IsHandleCreated)
                {
                    string slogan = slogans[rnd.Next(slogans.Count)];
                    //sloganlabel, som er sat ind på forsiden på sloganpanel, skal indeholde tekst fra List -Gøres ved invoke
                    sloganLabel.BeginInvoke(new Action(() => sloganLabel.Text = slogan));
                }
                //slogan skal skifte hvert 3. minut
                Thread.Sleep(TimeSpan.FromMinutes(3));
            }
        }
        private void Forside_Load(object sender, EventArgs e)
        {
            waitListBtn.Visible = false;
            editBtn.Visible = false;
            leaseBtn.Visible = false;
            reservationBtn.Visible = false;
            logoutBtn.Visible = false;
            panel5.Visible=false;
        }
        private void Forside_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Husk altid at lukke thread'en, ellers kører programmet stadig.
            thread.Abort();
        }
        public void createBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Create frm = new Create() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }
        public void readBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Read frm = new Read() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }
        public void editBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Edit frm = new Edit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }
        public void statsBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Stats frm = new Stats() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }
        public void reservationBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Reservation frm = new Reservation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }
        public void waitListBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            WaitList frm = new WaitList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }
        public void leaseBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Lease frm = new Lease() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }
        public void searchBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Search frm = new Search() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }
        public bool open = true;
        public void loginBtn_Click(object sender, EventArgs e)
        {
            //toggle
            if (open == true)
            {
                panel5.Show();
                open = false;
            }
            else if (open == false)
            {
                panel5.Hide();
                open = true;
            }
        }
        public void lBTN_Click(object sender, EventArgs e)
        {
            //Login button

            string id = idBox.Text;
            string pass = passBox.Text;

            //assumption: //double assumption dont assume anything
            bool id_ok = false, pass_ok = false;

            // length check:
            if (id.Contains("1")) id_ok = true;
            if (pass.Contains("root")) pass_ok = true;

            if (id_ok && pass_ok)
            {
                MessageBox.Show("Du er logget ind som adminstrator");
                waitListBtn.Visible = true;
                editBtn.Visible = true;
                leaseBtn.Visible = true;
                reservationBtn.Visible = true;
                loginBtn.Visible = false;
                logoutBtn.Visible = true;
                panel5.Hide();
            }
            else { MessageBox.Show("Prøv igen du"); }
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            waitListBtn.Visible = false;
            editBtn.Visible = false;
            leaseBtn.Visible = false;
            reservationBtn.Visible = false;
            logoutBtn.Visible = false;
            loginBtn.Visible = true;
        }
        private void lboligBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
