using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitComverter {
    public class DistanceUnit {
        public string Name { get; set; }
        public double Coefficient { get; set; }//単位の名称
        public override string ToString() {
            return this.Name;
        }
    }

}
