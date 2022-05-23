using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;


namespace SoenderBoP
{
    internal class Print
    {
        public static void PrintIt(DataGridView dgv, string writerName, string[] headersarr)
        {
            string headers = "";
            for (int i = 0; i < headersarr.Length; i++)
            {
                headers += PadBoth(headersarr[i], 50) + " | ";
            }

            TextWriter writer = new StreamWriter($@"..\..\..\SoenderBoP\Resources\{writerName}.Txt");
            writer.WriteLine(headers);
            for (int i = 0; i < dgv.Rows.Count - 1; i++) // rows
            {
                for (int j = 0; j < dgv.Columns.Count; j++) // columns
                {
                    if (j == dgv.Columns.Count - 1) // if last column
                    {
                        writer.WriteLine(PadBoth(dgv.Rows[i].Cells[j].Value.ToString(), 50));
                    }
                    else
                        writer.Write(PadBoth(dgv.Rows[i].Cells[j].Value.ToString(), 50) + "|");
                }
            }
            writer.Close();
            MessageBox.Show("Exported");
        }
        public static string PadBoth(string source, int length)
        {
            int spaces = length - source.Length;
            int padLeft = spaces / 2 + source.Length;
            return source.PadLeft(padLeft).PadRight(length);

        }
    }
}
