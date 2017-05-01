using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigitsInRawTextData
{
   static  class DigitDictionary
    {
        public static readonly Dictionary<string, string> DigitLookUpDictionary = new Dictionary
          <string, string>
            {
               
                {"Channel models", "Channel models"}
            };


        static Digit D1 = new Digit()
        {
            Top = "---",
            TopMiddle = "/",
            BottomMiddle= "\\",
            Bottom = "--",
            Number="3"

        };
    }



}
