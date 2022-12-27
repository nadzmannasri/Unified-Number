﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unifiednumber
{
    class unifiednumber
    {
        private int _value;

        public int Value 
        {   
            get { return _value; }
            set { _value = value; }
        }

        public string ToArabic()
        {
            
            string ArbStr = "";
            string DecStr = _value.ToString();
            for (int c = 0; c < DecStr.Length; c++)
            {
                if (DecStr[c] == '0')
                {
                    ArbStr = ArbStr + "۰";
                }
                else if (DecStr[c] == '1')
                {
                    ArbStr = ArbStr + "۱";
                }
                else if (DecStr[c] == '2')
                {
                    ArbStr = ArbStr + "۲";
                }
                else if (DecStr[c] == '3')
                {
                    ArbStr = ArbStr + "۳";
                }
                else if (DecStr[c] == '4')
                {
                    ArbStr = ArbStr + "٤";
                }
                else if (DecStr[c] == '5')
                {
                    ArbStr = ArbStr + "۵";
                }
                else if (DecStr[c] == '6')
                {
                    ArbStr = ArbStr + "٦";
                }
                else if (DecStr[c] == '7')
                {
                    ArbStr = ArbStr + "٧";
                }
                else if (DecStr[c] == '8')
                {
                    ArbStr = ArbStr + "٨";
                }
                else if (DecStr[c] == '9')
                {
                    ArbStr = ArbStr + "٩";
                }
            }
                return ArbStr;
        }
    }
}
