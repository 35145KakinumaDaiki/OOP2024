﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_p38 {
    public class Program {
        static void Main(string[] args) {
            Employee employee = new Employee {
                Id = 100,
                Name = "山田太郎",
                Birthday = new DateTime(1992, 4, 5),
                DivisionName = "第一営業部",
            };
            Student student = new Student {
                Name = "柿沼大貴",
                Birthday = new DateTime(2004, 5,31),
                Grade = 2,
                Classnumber = 1
               
            };
            Console.WriteLine("{0}({1})は、{2}に所属しています。",
                employee.Name,employee.GetAge(),employee.DivisionName);


            Console.WriteLine("{0}-{2}年{3}組 {1:yyyy/M/d}生まれ。",
                student.Name,student.Birthday,student.Grade,student.Classnumber);

            Person person = student;
            if (person is Student)
                Console.WriteLine("person is Student");

            object obj = student;
            if (obj is Student)
                Console.WriteLine("obj is Student");
        }
    }
}
