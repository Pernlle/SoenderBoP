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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            FillDataSource.SetUpDGV(editMedlemDGV, GetSqlCom());

        }

        //Hent værdier fra DGV
        private void medlemDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = editMedlemDGV.Rows[e.RowIndex];
                navnLabel.Text = dgvRow.Cells[1].Value.ToString();
                tlfMTxt.Text = dgvRow.Cells[2].Value.ToString();
                emailMTxt.Text = dgvRow.Cells[3].Value.ToString();
            }
        }

        //UPDATE
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //disse text vil blive udfyldt når man trykker på dgv og kan herefter kunne ændres, hvis man ønsker at opdatere dem (UPDATE KNAP)
            int phone = Convert.ToInt32(tlfMTxt.Text);
            string email = emailMTxt.Text;

            // Sætter values ind i en array, så de kan sendes over i metoderne (CRUD)
            object[] data = { phone, email };

            //hvilken tabel i db som skal arbejdes med
            string insertInto = "Medlem";
            // lav en add for hver parameter? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            //Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
            string add = "tlf,email";

            // valgte medlem i DGV, som skal opdateres (nuværende data vises i tekstboksene, og kan herefter ændres på.)
            int selectedRowIndex = editMedlemDGV.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = editMedlemDGV.Rows[selectedRowIndex];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);

            //Opdater det medlem som er corresponding til den valgte celle i DGV
            string where = $"mId={cellValue}";
            CRUD.Update(insertInto, add, where, data);

            FillDataSource.SetUpDGV(editMedlemDGV, GetSqlCom());

            //fjern fra observerpattern
            if (unObserveMcheckBx.Checked == true)
            {
                //ObserverPattern.UnRegister(observer==email);
            }
        }

        //DELETE
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //hvilken tabel i db som skal arbejdes med
            string insertInto = "Medlem";
            // valgte medlem som skal slettes - valgt via dgv
            int selectedRowIndex = editMedlemDGV.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = editMedlemDGV.Rows[selectedRowIndex];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);

            // Call metoden 'Yes_No'
            Yes_no(cellValue, insertInto);
            FillDataSource.SetUpDGV(editMedlemDGV, GetSqlCom());

            //Fjern fra observerpattern
            //ObserverPattern.UnRegister(observer==email);
        }

        //Messagebox med Yes/No
        public void Yes_no(string cellValue, string insertInto)
        {
            string box_msg = $"Er du sikker på at du vil slette {insertInto}";
            string box_title = "Tryk ja eller nej";

            // Viser en messagebox med to valg - yes, no
            var selectedOption = MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo);
            //Hvis du trykker ja til at slette kunde
            if (selectedOption == DialogResult.Yes)
            {
                if (cellValue != "" || cellValue == "0")
                {
                    //Gem insertinto, da der skal slettes flere ting.
                    string insertInto_ = insertInto;
                    insertInto = "Venteliste";
                    string delete = "vMId = " + cellValue;
                    //Slet Venteliste hvor mId = den valgte 
                    CRUD.Delete(insertInto, delete);

                    //Slet Medlem hvor mId = den valgte 
                    insertInto = insertInto_;
                    delete = "mId = " + cellValue;
                    CRUD.Delete(insertInto, delete);
                    MessageBox.Show("Medlem slettet");
                    FillDataSource.SetUpDGV(editMedlemDGV, GetSqlCom());
                }
                else
                {
                    MessageBox.Show("Vælg noget at slette");
                }
            }
            // Hvis du trykker nej til at slette kunde
            else if (selectedOption == DialogResult.No) { MessageBox.Show("Godt valg "); }
        }

        //Henter SQL til DGV
        public static string GetSqlCom()
        {
            string sqlCom = "SELECT mId AS 'ID',fNavn + ' ' + eNavn AS 'Navn',tlf AS 'Telefonnummer',email AS 'Email',mLNr AS 'Løbenummer' FROM Medlem";
            return sqlCom;
        }

        //Ubrugt kode der ikke kan fjernes
        private void Edit_Load(object sender, EventArgs e){}
    }
}
