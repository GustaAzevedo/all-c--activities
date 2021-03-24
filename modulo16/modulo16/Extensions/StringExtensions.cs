using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string str, int num)
        {
            if(str.Length <= num)
            {
                return str;
            }
            else
            {
                return str.Substring(0, num) + "...";
            }
        }
    }
}
