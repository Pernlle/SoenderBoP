using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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

                    checkIfTrue = true;
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
            if (checkIfTrue == true)
            {
                return true;
            }
            else { return false; }
        }
    }
}
