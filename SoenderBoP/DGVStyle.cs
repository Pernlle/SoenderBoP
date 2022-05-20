using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoenderBoP
{
    internal class DGVStyle
    {

        public static DataGridView GetDGVStyle(DataGridView DataGridView)
        {

            DataGridView.BackgroundColor = Color.FromKnownColor(KnownColor.Linen); // baggrunden bag ved dgv
            DataGridView.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Linen); //celle farve :)



            DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.IndianRed);
            DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.Font, FontStyle.Regular);
            DataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Transparent;

            /*
                Cells style:
             */
            
            DataGridView.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Linen);
            DataGridView.DefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DataGridView.DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.ControlLight);
            DataGridView.DefaultCellStyle.SelectionForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DataGridView.DefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 14);
            DataGridView.DefaultCellStyle.Padding = new Padding(2);
            DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            /*
                Header cells style:
             */

            DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Linen);
            DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.ControlLight);
            DataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 14);
            DataGridView.ColumnHeadersDefaultCellStyle.Padding = new Padding(2);
            DataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            DataGridView.Location = new Point(8, 8);
            DataGridView.Size = new Size(500, 250);

            DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            DataGridView.GridColor = Color.Black;

            DataGridView.RowHeadersVisible = false;

            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.MultiSelect = false;
            DataGridView.Dock = DockStyle.Fill;

            DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Linen;
            DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.Font, FontStyle.Bold);

            //Allow User to:
            DataGridView.AllowDrop = false;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToResizeRows = false;
            DataGridView.AllowUserToResizeColumns = false;
            DataGridView.AllowUserToDeleteRows = false;
   
            return DataGridView;
        }
    }
}
