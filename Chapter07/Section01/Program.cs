using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



internal class Program {
    static void Main(string[] args) {

        var prefectureOfficeDict = new Dictionary<string, string>();

        Console.WriteLine("県庁所在地の登録");
        for (int i = 0; i < 5; i++) {

            //都道府県の入力
            Console.Write("都道府県:");
            string prefecture = Console.ReadLine();

            //県庁所在地の入力
            Console.Write("県庁所在地");
            string city = Console.ReadLine();

            //すでに都道府県が登録されているか
            if (prefectureOfficeDict.ContainsKey(prefecture) || prefectureOfficeDict.ContainsKey(city)) {
                Console.WriteLine("上書きしますか？");
                string ans = Console.ReadLine();
                if (ans == "yes") {
                    prefectureOfficeDict[prefecture] = city;
                    i -= 1;
                }
            } else {
                prefectureOfficeDict[prefecture] = city;
            }
        }

        Boolean endFlag = false;//終了フラグ
        while (true) {
            Console.WriteLine("****メニュー****");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("9:終了");
            Console.Write(">");
            string menuSelect = Console.ReadLine();
            switch(menuSelect) {
                case "1":
                    //一覧処理
                    foreach (var item in prefectureOfficeDict) {
                        Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");
                    }
                    break;

                case "2":
                    //都道府県の入力
                    Console.Write("都道府県:");
                    string prefecture = Console.ReadLine();
                    Console.WriteLine(prefecture + "の県庁所在地は" + prefectureOfficeDict[prefecture] + "です。");
                    break;

                case "9":
                    endFlag = true;//終了フラグON
                    break;

            }
            if (endFlag) {
                break;
            }
        }

       










    }


}
