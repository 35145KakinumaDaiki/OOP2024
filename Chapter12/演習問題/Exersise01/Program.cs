using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;


namespace Exersise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var emps = new Employee[] {
                new Employee {
                    Id = 1,
                    Name = "阿部　伸二",
                    HireDate = new DateTime(2003, 1, 1),
                }
            };

            using(var writer = XmlWriter.Create(outfile)) {
                var serializer = new XmlSerializer(emps.GetType());
                serializer.Serialize(writer, emps);
            }
        }

        private static void Exercise1_2(string outfile) {
            var emps = new Employee[] {
                new Employee {
                    Id = 123,
                    Name = "出井　秀幸",
                    HireDate= new DateTime(2001,3,1),
                },
                new Employee {
                    Id=1,
                    Name = "長谷部　勇気",
                    HireDate= new DateTime(1998 ,11,27),
                }
            };
            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using(var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
            }
        }

        private static void Exercise1_3(string file) {
            using(var reader = XmlReader.Create(file)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var employee = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps) {
                    Console.WriteLine("{0} {1} {2}",emp.Id,emp.Name,emp.HireDate);
                }
            }

           
        }

        private static void Exercise1_4(string file) {
            
        }
    }
}
