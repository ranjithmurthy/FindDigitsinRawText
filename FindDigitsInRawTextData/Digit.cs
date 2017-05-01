using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigitsInRawTextData
{
    public  class Digit
    {
        public string Number { get; set; }
        public string Top { get; set; }
        public string TopMiddle { get; set; }
        public string BottomMiddle { get; set; }
        public string Bottom { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="top"></param>
        /// <param name="topMiddle"></param>
        /// <param name="bottomMiddle"></param>
        /// <param name="bottom"></param>
        public Digit(string top  ,string topMiddle, string bottomMiddle, string bottom)
        {
            Top = top;
            TopMiddle = topMiddle;
            BottomMiddle = bottomMiddle;
            Bottom = bottom;
        }

        /// <summary>
        /// This Constructor is used when Creating Dictionary 
        /// </summary>
        /// <param name="top"></param>
        /// <param name="topMiddle"></param>
        /// <param name="bottomMiddle"></param>
        /// <param name="bottom"></param>
        /// <param name="keyNumber"></param>
        public Digit(string top, string topMiddle, string bottomMiddle, string bottom, string keyNumber) :this (top,  topMiddle,  bottomMiddle,  bottom)
        {
            Number = keyNumber;
        }


        public Digit()
        {

        }

        public override string ToString()
        {
            //return String.Format("Name: {0}, Number:{1}, Date:{2}, Salary:{3}", _name, _number, _date, _salary);

            return "1";
        }


    }
}
