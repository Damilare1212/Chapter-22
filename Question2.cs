using System;
using System.Linq;
using System.Collections.Generic;

namespace Chapter_22
{
    public static class  IenumerableClass
    {
        public static int Addition(this IEnumerable<int> num)
        {
            return num.Sum();
        }

         public static int Lowest(this IEnumerable<int> num)
        {
            return num.Min();
        }

       public static int LArgest(this IEnumerable<int> num)
        {
            return num.Min();
        }

       public static double Averag(this IEnumerable<int> num)
        {
            return num.Average();
        }

        public static void Answer()
        {
              List<int> Mylist = new List<int>() {1,2,3,4,5,} ;

            var result = Mylist.Addition();
            Console.WriteLine($" Sum result = {result}");

            var results = Mylist.Lowest();
            Console.WriteLine($" min result = {results}");
            

            var Result = Mylist.LArgest();
            Console.WriteLine($" max result = {Result}");
            

           var rEsult = Mylist.Averag();
           Console.WriteLine($"average result = {rEsult}");
        }
        
    }
}