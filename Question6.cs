using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Globalization;

namespace  Chapter_22
{
    class Question6
    {
        public static void Answer()
        {
            List<int> Mylist = new List<int>() {23,35 ,21, 66,2} ;

            // using query syntax
            var t = Mylist.Where(item => item % 7 == 0 && item % 3 == 0).ToList();
            foreach(var xl in t)
            {
                Console.WriteLine($"{xl} ");
            }
            //using method syntax 
            var w = from item in Mylist where item % 3 == 0 && item % 7 == 0 select item;

            foreach (var item in w)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}