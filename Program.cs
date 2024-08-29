using System;

namespace Patikafy
{


    class Program
    {
        static void Main(string[] args)
        {

            List<Singer> list = new List<Singer>();
            list.Add(new Singer { NameSurname = "Ajda Pekkan", RelaseDate = 1968, MusicType = "Pop", TotalSellAlbumCount = 20000000 });
            list.Add(new Singer { NameSurname = "Sezen Aksu", RelaseDate = 1971, MusicType = "Türk Halk Müziği/Pop", TotalSellAlbumCount = 10000000 });
            list.Add(new Singer { NameSurname = "Funda Arar", RelaseDate = 1999, MusicType = "Pop", TotalSellAlbumCount = 3000000 });
            list.Add(new Singer { NameSurname = "Sertab Erener", RelaseDate = 1994, MusicType = "Pop", TotalSellAlbumCount = 5000000 });
            list.Add(new Singer { NameSurname = "Sıla Gençoğlu", RelaseDate = 2009, MusicType = "Pop", TotalSellAlbumCount = 3000000 });
            list.Add(new Singer { NameSurname = "Serdar Ortaç", RelaseDate = 1994, MusicType = "Pop", TotalSellAlbumCount = 10000000 });
            list.Add(new Singer { NameSurname = "Tarkan", RelaseDate = 1992, MusicType = "Pop", TotalSellAlbumCount = 40000000 });
            list.Add(new Singer { NameSurname = "Hande Yener", RelaseDate = 1999, MusicType = "Pop", TotalSellAlbumCount = 7000000 });
            list.Add(new Singer { NameSurname = "Hadise", RelaseDate = 2005, MusicType = "Pop", TotalSellAlbumCount = 5000000 });
            list.Add(new Singer { NameSurname = "Gülben Ergen", RelaseDate = 1997, MusicType = "Türk Halk Müziği/Pop", TotalSellAlbumCount = 10000000 });
            list.Add(new Singer { NameSurname = "Neşet Ertaş", RelaseDate = 1960, MusicType = "Türk Halk Müziği/Türk Sanat Müziği", TotalSellAlbumCount = 2000000 });

            var nameStartS = list.Where(x => x.NameSurname.StartsWith("S", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Name Start the S Singer names");
            foreach (var item in nameStartS)
            {
                Console.WriteLine(item.NameSurname);
            }

            var greaterThanTen = list.Where(y => y.TotalSellAlbumCount > 10000000);
            Console.WriteLine("Total Sell Albums Greater Than 10 Million");
            foreach (var item in greaterThanTen)
            {
                Console.WriteLine(item.NameSurname);
            }


            var groupedByReleaseDate =
            list.Where(z => z.RelaseDate < 2000 && z.MusicType.ToLower().Contains("pop"))
            .GroupBy(z => z.RelaseDate)
           .OrderBy(g => g.Key);

            Console.WriteLine("\nGrouped by Release Date: Before Than 2000 And Pop Music");
            foreach (var group in groupedByReleaseDate)
            {
                Console.WriteLine($"Release Date: {group.Key}");
                foreach (var item in group.OrderBy(i => i.NameSurname))
                {
                    Console.WriteLine($" - {item.NameSurname}");
                }
            }

            var maxSell = list.Max(m => m.TotalSellAlbumCount);

            var MaxsellPerson = list.Where(z => z.TotalSellAlbumCount == maxSell);

            foreach (var item in MaxsellPerson)
            {


                Console.WriteLine($"Max Sell Albums Singer:{item.NameSurname}");

            }


            var oldSinger = list.Min(s => s.RelaseDate);

            var oldSingersnName = list.Where(singer => singer.RelaseDate == oldSinger);


            foreach (var item in oldSingersnName)
            {


                Console.WriteLine($"Old Singer Name:{item.NameSurname}");

            }

            var newSinger = list.Max(s => s.RelaseDate);

            var newSingersnName = list.Where(singer => singer.RelaseDate == newSinger);


            foreach (var item in newSingersnName)
            {


                Console.WriteLine($"New Singer Name:{item.NameSurname}");

            }
        }
    }
}