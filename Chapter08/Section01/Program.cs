using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var cultureJp = new CultureInfo("ja-jp", false);
            cultureJp.DateTimeFormat.Calendar = new JapaneseCalendar();
            Console.WriteLine("生年月日を入力");
            Console.Write("年:");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月:");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);
            //Console.WriteLine("あなたは" + birthday.ToString("ddd") + "曜日に生まれました。");

            //あなたは平成○○年○月〇日に生まれました。
            Console.WriteLine("あなたは" + birthday.ToString("ggy年M月d日",cultureJp) + "に生まれました。");

            //あなたは生まれてから今日で○○○○日目です。
            var nowDate = DateTime.Today;
            var totaldays = nowDate.Subtract(birthday) .TotalDays + 1;

            Console.WriteLine("あなたは生まれてから今日で" + totaldays + "日目です。");

          

        }
    }
}
