using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace SoenderBoP
{
    public class InputValidation
    {
        public static bool InputValidate(object[] data)
        {
            bool checkIfTrue = false;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is string)
                {
                    // lenght check:
                    if (data[i].ToString().Length <=60) checkIfTrue = true; //60 er det højeste antal i databasen (VARCHAR)
                    // "<" check for JS tags (ingen cross site scripting):
                    if (!data[i].ToString().Contains("<")) checkIfTrue= true; //input må ikke indholde <
                    // regulat expressions check:
                    Regex regX = new Regex(@"(^[-a-z æøå A-Z ÆØÅ 0-9_.@]*$)"); //dk-hostmaster.dk -SKAL MAN KUNNE SKRIVE ÆØÅ? svar: IKKE I EMAIL, DA DET LATINSKE ALFABET ER DET MEST ACCEPTEREDE CROSS PLATFORM-
                    if (regX.IsMatch(data[i].ToString())) checkIfTrue = true; //check for RegX
                }
                else if (data[i] is int)
                {
                    //try cattch for converttoint = tag ikke stilling til indholdet, kun om det er et tal?
                    try { Convert.ToInt32(data); checkIfTrue = true; }catch { }
                    //check på længde (hvor mange cifre)
                    if (data[i].ToString().Length <= 10)
                    checkIfTrue = true;
                }
                else if (data[i] is DBNull)
                {
                    checkIfTrue = true; //Hvis data[i] er nået her ind er den højest sandsynligt rigtig (DATABASEN SIGER NEJ; HVIS DET IKKE KAN VÆRE EN NULL)
                }
                else { checkIfTrue = false; }
            }
            //Return
            if (checkIfTrue == true)
            {
                return true;
            }
            else { return false; }
        }
    }
}
