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
    public class Print
    {
        public static void PrintIt(DataGridView dgv, string writerName, string[] headersarr, string title)
        {
            string headers = "";
            for (int i = 0; i < headersarr.Length; i++)
            {
                headers += PadBoth(headersarr[i], 30) + "|";
            }
            headers = headers.Remove(headers.Length - 1);

            TextWriter writer = new StreamWriter($@"..\..\..\Udskrifter\{writerName}.Txt");
            writer.WriteLine(title);
            writer.WriteLine(headers);
            for (int i = 0; i < dgv.Rows.Count; i++) // rows
            {
                for (int j = 0; j < dgv.Columns.Count; j++) // columns
                {
                    if (j == dgv.Columns.Count - 1) // if last column
                    {
                        writer.WriteLine(PadBoth(dgv.Rows[i].Cells[j].Value.ToString(), 30));
                    }
                    else
                        writer.Write(PadBoth(dgv.Rows[i].Cells[j].Value.ToString(), 30) + "|");
                }
            }
            writer.Close();
            MessageBox.Show("Gemt til 'Udksrifter'");
        }
        public static string PadBoth(string source, int length)
        {
            int spaces = length - source.Length;
            int padLeft = spaces / 2 + source.Length;
            return source.PadLeft(padLeft).PadRight(length);

        }
    }
}
