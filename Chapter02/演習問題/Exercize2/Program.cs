using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize2 {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintIntiToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToIntiList(int.Parse(args[1]), int.Parse(args[2]));
            }

        }

        private static void PrintIntiToMeterList(int start, int stop) {
            for (int inti = start; inti <= stop; inti++) {
                double meter = IntiConverter.ToMeter(inti);
                Console.WriteLine("{0}inti = {1:0.0000}m", inti, meter);
            }
        }


        private static void PrintMeterToIntiList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double inti = IntiConverter.FromMeter(meter);
                Console.WriteLine("{0}inti = {1:0.0000}m", meter, inti);
            }
        }
    }
}
