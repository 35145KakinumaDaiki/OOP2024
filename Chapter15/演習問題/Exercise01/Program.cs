using Section01;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books
                            .Max(b => b.Price);
            
            var book = Library.Books
                            .First(b=>b.Price == max);
            Console.WriteLine(book);
            
        }

        private static void Exercise1_3() {
            var query = Library.Books
                            .GroupBy(b => b.PublishedYear)
                            .Select(g => new { PublishedYear = g.Key,Count = g.Count()})
                            .OrderBy(x=>x.PublishedYear);
            foreach(var item in query) {
                Console.WriteLine("{0}年　{1}冊",item.PublishedYear,item.Count);
            }
        }

        private static void Exercise1_4() {
            var selected = Library.Books.OrderByDescending(b=>b.PublishedYear)
                                        .ThenByDescending(b=>b.Price)
                                        .Join(Library.Categories,//結合する2番目のシーケンス
                                        book=> book.CategoryId,//対象シーケンスの結合キー
                                        category => category.Id,
                                        (book, category) => new {
                                            book.Title,
                                            book.Price,
                                            Category = category.Name,
                                            book.PublishedYear,
                                        });
            foreach (var book in selected) {
                Console.WriteLine($"{book.PublishedYear}年{book.Price}円{book.Title}({book.Category})");
            }
        }

        private static void Exercise1_5() {
            var query = Library.Books.Where(b => b.PublishedYear == 2016)
                                            .Join(Library.Categories, book => book.CategoryId,
                                             category => category.Id,
                                            (book, category) => category.Name)
                                            .Distinct();
            foreach (var name in query)
                Console.WriteLine(name); 
            
                                  
        }

        private static void Exercise1_6() {
            var groups = Library.Categories
                                .GroupJoin(Library.Books,
                                c => c.Id,
                                b => b.CategoryId,
                                (c, books) => new { Category = c.Name, Books = books })
                                .OrderBy(x=> x.Category);
            foreach(var group in groups) {
                Console.WriteLine("#{0}",group.Category);
                foreach(var book in group.Books) {
                    Console.WriteLine("   {0}",book.Title);
                }
            }
                                
        }

        private static void Exercise1_7() {
            var categoriesid = Library.Categories.Single(c=>c.Name == "Development").Id;
            var query = Library.Books.Where(b => b.CategoryId == categoriesid)
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(b => b.Key);
            foreach (var group in  query) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var item in group) {
                    Console.WriteLine("   {0}", item.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var groups = Library.Categories
                                .GroupJoin(Library.Books,
                                c => c.Id,
                                b => b.CategoryId,
                                (c, book) => new { Category = c.Name, Count = book.Count() })
                                .Where(b => b.Count >= 4);
           foreach (var group in groups) {
                Console.WriteLine("{0} ({1}冊)",group.Category,group.Count);
            
            }
                           
                                
            

        }
    }
}
