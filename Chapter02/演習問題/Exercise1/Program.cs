using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Program {
        static void Main(string[] args) {
            //2.1.3
            var Songs = new Song[] {
                new Song("LET it be", "THE Beatles",243),
                new Song("Bride Over", "simon", 293),
                new Song("njknia", "oki", 276),
                new Song("anivje", "kikfen",343),
                new Song("dfevv", "dfeergeg",222)


            };
            
            PrintSongs(Songs);

        }



        //2.1.4
        private static void PrintSongs(Song[] songs) {

            foreach (var song in songs) {

                Console.WriteLine(@"{0}, {1}{2:mm\:ss}",song.Title,song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }

        }
    }
}
