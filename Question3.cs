using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace Chapter_22
{
    public class Student
    {
        public string Firstname {get;set;}
        public string Lastname {get;set;}
        public int Age {get;set;}

        public static void Answer()
        {
            
            List<Student> student = new List<Student>()
            {
                new Student() {Firstname = "Ade", Lastname = "bola", Age = 34},
                new Student() {Firstname = "Ada", Lastname = "Ade", Age = 19},
                new Student() {Firstname = "Portable", Lastname = "Zazu", Age = 34},
                 new Student() {Firstname = "Zazu", Lastname = "Zeh", Age = 34},     
            };
            
            var x = from item in student where item.Firstname.CompareTo(item.Lastname) == -1 select item;

            foreach(var it in x)
            {
                Console.WriteLine($" {it.Firstname}  {it.Lastname}");
            }

        }
    }
}