using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var str1 = Console.ReadLine();
            int num;

            if (int.TryParse(str1, out num)) {
                Console.WriteLine("{0:#,#}", num);
            } else {
                Console.WriteLine("数値文字列でありません");
            }
        }
    }
}
