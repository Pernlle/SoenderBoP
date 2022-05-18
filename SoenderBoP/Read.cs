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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
        }

        private void Read_Load(object sender, EventArgs e)
        {
            string sqlcom = "SELECT mId AS 'Medlem ID',fNavn AS 'Fornavn',eNavn AS 'Efternavn',tlf AS 'Telefonnummer',email AS 'Email',lNr AS 'Løbenummer' FROM Medlem";
            readMedlemDGV.DataSource= FillDataSource.GetDataSource(sqlcom);
            readMedlemDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            sqlcom = "SELECT bId AS 'Bolig ID', mndPris AS 'Måneds pris',adr AS 'Adresse',kvm AS 'Kvm',bType AS 'Bolig type',loebeNr AS 'Løbenummer' FROM Bolig";
            readBoligDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            readBoligDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            sqlcom = "SELECT * FROM Reserveret";
            readReserveDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            readReserveDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
