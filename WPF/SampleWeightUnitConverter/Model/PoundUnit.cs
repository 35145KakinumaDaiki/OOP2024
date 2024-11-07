﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter {
    public class PoundUnit : WeightUnit{
        //ポンド単位を表すクラス
            private static List<PoundUnit> units = new List<PoundUnit> {
            new PoundUnit{ Name = "oz", Coefficient = 1,},
            new PoundUnit{ Name = "pd", Coefficient = 16,},
            new PoundUnit{ Name = "stn", Coefficient = 16 * 14,},
          
        };
            public static ICollection<PoundUnit> Units { get { return units; } }

        /// <summary>
        /// グラム単位からポンド単位に変換
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FromGramUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient) / 28.35 / this.Coefficient;
        }
    }
}
