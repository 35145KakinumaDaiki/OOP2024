using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Program {
    static void Main(string[] args) {

        var prefectureOfficeDict = new Dictionary<string, string>();

        Console.WriteLine("県庁所在地の登録");
        for (int i = 0; i < 5; i++) {
            Console.Write("都道府県:");
            string prefecture = Console.ReadLine();

            Console.Write("県庁所在地");
            string city = Console.ReadLine();

            if (prefecture.Contains(Console.ReadLine()) || city.Contains(Console.ReadLine())) {
                Console.WriteLine("すでに登録済みです");
            } else {
                prefectureOfficeDict[prefecture] = city;
            }



        }

        foreach (var item in prefectureOfficeDict) {
            Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");
        }










    }


}
