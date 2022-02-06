using System;
using System.Collections.Generic;
using System.Linq;
 
 namespace Chapter_22
 {
     public  class Question4
     {
         public static void Answer()
         {

        
            List<Student> student = new List<Student>()
            {
                new Student() {Firstname = "Ade", Lastname = "bola", Age = 34},
                new Student() {Firstname = "Abex", Lastname = "Adex", Age = 19},
                new Student() {Firstname = "Ade", Lastname = "bola", Age = 34},
                new Student() {Firstname = "Zazu", Lastname = "Zeh", Age = 34},     
            };
            
            
            var y = student.Where(x => x.Age > 18 && x.Age <= 24).ToList();
            foreach(var item in y)
            {
                Console.WriteLine($"{item.Firstname} {item.Lastname}");
            }
        }          
            
     }
 }