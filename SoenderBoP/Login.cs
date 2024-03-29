﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void loginBtn_Click(object sender, EventArgs e)
        {
            
            Forside forside = new Forside();

            string id = idBox.Text;
            string pass = passBox.Text;


            //double assumption dont assume anything
            bool id_ok = true, pass_ok = true;

            // length check:
            if (id.Contains("1")) id_ok = true;
            if (pass.Contains("root")) pass_ok = true;

            if (id_ok && pass_ok)
            {
                MessageBox.Show("Du er logget ind som adminstrator");
                forside.Update();
                forside.waitListBtn.Visible = true;
                forside.editBtn.Visible = true;
                forside.leaseBtn.Visible = true;
                forside.reservationBtn.Visible = true;
            }
            else { MessageBox.Show("Prøv igen du"); }
        }
    }
}
