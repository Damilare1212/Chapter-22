using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Globalization;

namespace Chapter_22
{
  public static class Question7
    {
        
       
            public static string CapitalizeAllFistLetter( this string text)
            {
              return  new CultureInfo("en-US", false).TextInfo.ToTitleCase(text);
            }

            public static void Answer()
            {
                 Console.WriteLine();
              string Convert = "i am a shining star";
              var ans = Convert.CapitalizeAllFistLetter();
              Console.WriteLine($"{ans} ");
            }
       
    }
}