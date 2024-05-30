using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            int notnum = text.Count(s => s == ' ');
            Console.WriteLine("空白数:" + notnum);
        }

        private static void Exercise3_2(string text) {
            var rep = text.Replace("big", "small");
            Console.WriteLine(rep);
        }

        private static void Exercise3_3(string text) {
            int word = text.Count(s => s == ' ') + 1;
            Console.WriteLine("単語の数:" + word);
        }

        private static void Exercise3_4(string text) {
           
        }

        private static void Exercise3_5(string text) {
           
        }
    }
}
