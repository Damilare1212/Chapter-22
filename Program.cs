using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Chapter_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

          Console.WriteLine("Enter 1 for question 1\nEnter 2 for question 2\nEnter 3 for question 3\nEnter 4 for question 4\nEnter 5 for question 5\nEnter 6 for question 6\nEnter 7 for question7");
            var answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                StringExtension.Answer();
            }
            if (answer == 2)
            {
                 IenumerableClass.Answer();
            }
            if (answer == 3)
            {
                 Student.Answer();
            }
            if (answer == 4)
            {
                 Question4.Answer();
            }
            if (answer == 5)
            {
                 Question5.Answer();
            }
            if (answer == 6)
            {
                Question6.Answer();
            }
            if (answer == 7)
            {
                Question7.Answer();
            }


        }
    }
}
