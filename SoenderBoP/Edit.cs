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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //hvilken tabel i db som skal arbejdes med
            string insertInto = "Medlem";
            // valgte medlem som skal slettes - valgt via dgv
            string delete = ""; // dgv choice

            CRUD.Delete(insertInto, delete);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //disse text vil blive udfyldt når man trykker på dgv og kan herefter kunne ændres, hvis man ønsker at opdatere dem (UPDATE KNAP)
            int phone = Convert.ToInt32(emailMTxt.Text);
            string email = emailMTxt.Text;

            // Sætter values ind i en array, så de kan sendes over i metoderne (CRUD)
            object[] data = { phone, email };

            //hvilken tabel i db som skal arbejdes med
            string insertInto = "Medlem";
            // lav en add for hver parameter? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            //Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
            string add = "tlf,email";
            // lav en values add for hver value? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            string values = "@tlf,@email";

            string set = "tlf=@tlf, email=@email";
            string where = "mId=@mId";
            CRUD.Update(insertInto, add, set, where, values, data);
        }
    }
}
