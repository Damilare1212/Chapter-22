using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Chapter_22
{
    public class Question5
    {
        public static void Answer()
        {
            
            List<Student> student = new List<Student>()
            {
                new Student() {Firstname = "Ade", Lastname = "bola", Age = 34},
                new Student() {Firstname = "Abex", Lastname = "Adex", Age = 19},
                new Student() {Firstname = "Zazu", Lastname = "Zeh", Age = 34},
                 new Student() {Firstname = "Ada", Lastname = "Ade", Age = 34},     
            };
        
           
            // using method syntax
            var v = student.OrderBy(item => item.Firstname).ThenBy(item => item.Lastname);
            // using query syntax
            var z = from item in student orderby item.Firstname orderby item.Lastname select item;

            foreach (var item in v)
            {
                Console.WriteLine($"{item.Firstname} {item.Lastname} {item.Age}");
            }
            Console.WriteLine();

              foreach (var item in z)
            {
                Console.WriteLine($"{item.Firstname} {item.Lastname} {item.Age}");
            }
        }
    }
}