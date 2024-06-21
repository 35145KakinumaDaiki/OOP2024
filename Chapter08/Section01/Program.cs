using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("生年月日を入力");
            Console.Write("年:");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月:");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);
            DayOfWeek dayOfWeek = birthday.DayOfWeek;

            if (dayOfWeek == DayOfWeek.Friday) {
                 Console.WriteLine("あなたは金曜日に生まれました。");
             } else if (dayOfWeek == DayOfWeek.Monday) {
                 Console.WriteLine("あなたは月曜日に生まれました。");
             } else if (dayOfWeek == DayOfWeek.Sunday) {
                 Console.WriteLine("あなたは日曜日に生まれました。");
             } else if (dayOfWeek == DayOfWeek.Wednesday) {
                 Console.WriteLine("あなたは水曜日に生まれました。");
             } else if (dayOfWeek == DayOfWeek.Tuesday) {
                 Console.WriteLine("あなたは火曜日に生まれました。");
             }else if (dayOfWeek == DayOfWeek.Thursday) {
                 Console.WriteLine("あなたは木曜日に生まれました。");
             }





            /*var birthday = new DateTime(2004, 5, 31);
            DayOfWeek birthdayweek = birthday.DayOfWeek;
            Console.WriteLine(birthdayweek);*/



            /* var dt1 = new DateTime(2016, 2, 15);
             var dt2 = new DateTime(2004, 5, 31, 8, 45, 20);
             Console.WriteLine(dt1);
             Console.WriteLine(dt2);

             var today = DateTime.Today;
             var now = DateTime.Now;
             Console.WriteLine("Now : {0}" , now);

             var isLeapYear = DateTime.IsLeapYear(2024);
             if (isLeapYear) {
                 Console.WriteLine("閏年です");
             }else {
                 Console.WriteLine("閏年ではありません");
             }*/

        }
    }
}
