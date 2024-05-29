using Exercise01;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            // 4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1999, 4),
                new YearMonth(2004, 7),
                new YearMonth(2012, 9),
                new YearMonth(2122, 12),
};

            // 4.2.2
            Console.WriteLine("\n- 4.2.2 ---");
            Exercise2_2(ymCollection);
            Console.WriteLine("\n- 4.2.4 ---");

            // 4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("\n- 4.2.5 ---");


            // 4.2.5
            Exercise2_5(ymCollection);
        }

        //4.2.3(4.2.4で呼び出されるメソッド)
        static YearMonth FindFirst21c(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }

        private static void Exercise2_2(YearMonth[] yms) {
             foreach(var s in yms )
              Console.WriteLine(s);
            
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var century = FindFirst21c(ymCollection);
            if(century == null) {
                Console.WriteLine("21世紀のデータはありません");
            } else {
                Console.WriteLine(century);
            }
           
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();

            foreach(var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}
