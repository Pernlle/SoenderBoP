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
            //// length check:
            //if (Knavn.Length > 50) Knavn_ok = false;
            //if (Kadresse.Length > 50) Kadresse_ok = false;

            //// lower check:
            //if (Knavn != Knavn.ToLower()) Knavn_ok = false;
            //if (!(Kadresse == Kadresse.ToLower())) Kadresse_ok = false;

            //// "<" check for JS tags ... NO cross site scripting here.:
            //if (Knavn.Contains("<"))Knavn_ok = false;
            //if (Kadresse.Contains("<")) Kadresse_ok = false;

            //// regular expressions check:           
            //Regex re = new Regex(@"(^[a-z ]*$)");
            //if (!re.IsMatch(Knavn)) Knavn_ok = false;
            //if (!re.IsMatch(Kadresse)) Kadresse_ok = false;
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
                    Regex regX = new Regex(@"(^[-a-å A-Å 0-9_.@]*$)"); //dk-hostmaster.dk -SKAL MAN KUNNE SKRIVE ÆØÅ? svar: IKKE I EMAIL, DA DET LATINSKE ALFABET ER DET MEST ACCEPTEREDE CROSS PLATFORM-
                    if (regX.IsMatch(data[i].ToString())) checkIfTrue = true; //check for RegX
                }
                else if (data[i] is int)
                {

                    checkIfTrue = true;
                }
                else if (data[i] is DBNull)
                {

                    checkIfTrue = true;
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
