using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUtilities
{
    public class Utility
    {
       public string RemovePrecedingZero(string Textbox, string input2)
       {
           if (Textbox == "0")
           {
               Textbox = "";
           }
           var add = Textbox + input2;
           return add;
       
       }
    }
}
