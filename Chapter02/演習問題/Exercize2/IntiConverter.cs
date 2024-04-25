using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize2 {
    internal class IntiConverter {
        public static readonly double retio = 0.0254;//定数（外部にも公開する場合）



        //メートルからインチを求める
        public static double FromMeter(double meter) {
            return meter / retio;
        }

        //インチからメートルを求める
        public static double ToMeter(double inti) {
            return inti * retio;
        }
    }
}
