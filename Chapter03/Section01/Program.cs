using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 12, 4 };


            //int count = numbers.Count(n => n % 2 == 0);
            double num = numbers.Where(n => 5 < n).Average();
            int total = numbers.Where(n => 5 < n).Sum();
            Console.WriteLine(num);
            Console.WriteLine(total);
        }

       
       





    }
}
