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
    public partial class WaitList : Form
    {
        public WaitList()
        {
            InitializeComponent();
        }

        private void WaitList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'waitListViews.Seniorbolig' table. You can move, or remove it, as needed.
            this.seniorboligTableAdapter.Fill(this.waitListViews.Seniorbolig);
            // TODO: This line of code loads data into the 'waitListViews.Ungdomsbolig' table. You can move, or remove it, as needed.
            this.ungdomsboligTableAdapter.Fill(this.waitListViews.Ungdomsbolig);
            // TODO: This line of code loads data into the 'waitListViews.Lejlighed' table. You can move, or remove it, as needed.
            this.lejlighedTableAdapter.Fill(this.waitListViews.Lejlighed);

        }

        private void lejlighedDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void ungdomsDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void seniorDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.seniorDGV.Rows[e.RowIndex].Cells["rn"].Value=(e.RowIndex+1).ToString();
        }
    }
}
