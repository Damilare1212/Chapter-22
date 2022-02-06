using System;
using System.Collections.Generic;
using System.Collections;

namespace Chapter_22
{
    public static class StringExtension
    {
        public static string FindSubstring(this string strg, int index ,int length)
        {
            return strg.Substring(index,length);
        }

        public static void Answer()
        {
            string stri = "Adewale";
            var answer = stri.FindSubstring(1,1);
            Console.WriteLine(answer);

        }
    }
}