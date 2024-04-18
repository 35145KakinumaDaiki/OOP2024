using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product Karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(166, "大福", 204);

            int price = Karinto.Price;//税抜き
            int taxIncluded = Karinto.GetPriceIncludingTax();//税込み

            int daifukuPrice = daifuku.Price;
            int daifukuTaxIncluded = daifuku.GetPriceIncludingTax();

            Console.WriteLine( Karinto.Name + "の税込み金額" 
                                        + taxIncluded + "円[税抜き" + price + " 円]");

            Console.WriteLine(daifuku.Name + "の税込み金額"
                                        + daifukuTaxIncluded + "円[税抜き" + daifukuPrice + " 円]");








        }
    }
}
