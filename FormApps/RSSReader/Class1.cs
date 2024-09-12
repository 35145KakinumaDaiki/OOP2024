using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSReader {
    public class Class1 {
        public string Name { get; set; }
        public string Url { get; set; }

        public override string ToString() {
            return Name; // コンボボックスに表示するテキスト
        }
    }
}
