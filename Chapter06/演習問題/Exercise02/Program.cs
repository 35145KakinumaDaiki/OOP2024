using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            var books2 = books.Where(s=> s.Title == "ワンダフル・C#ライフ");
            foreach(var book in books2) {
                Console.WriteLine("{0}円{1}ページ", book.Price,book.Pages);
            }
            
        }

        private static void Exercise2_2(List<Book> books) {
            var count = books.Count(x=> x.Title.Contains("C#"));

            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<Book> books) {
            var page = books.Where(s=> s.Title.Contains("C#")).Average(s=> s.Pages);
            Console.WriteLine(page);
        }

        private static void Exercise2_4(List<Book> books) {
            var price = books.FirstOrDefault(x => x.Price >= 4000);
            Console.WriteLine(price.Title);
        }

        private static void Exercise2_5(List<Book> books) {
            var pages = books.Where(b => b.Price < 4000)
                                    .Max(b => b.Pages);
            Console.WriteLine(pages);
        }

        private static void Exercise2_6(List<Book> books) {
            var title = books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price);
            foreach(var title2 in title) {
                Console.WriteLine("{0}:{1}円",title2.Title,title2.Price);
            }
        }

        private static void Exercise2_7(List<Book> books) {
            var serch = books.Where(s => s.Title.Contains("C#")).Where(s => s.Pages <= 500);
            foreach(var serch2 in serch) {
                Console.WriteLine(serch2.Title);
            }
        }
    }
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}
