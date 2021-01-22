using System;

namespace odev
{
	class Program
	{
		static void Main(string[] args)
		{
          

                // Tanımladığımız class'tan nesneler oluşturuyoruz.

                Urun Urun1 = new Urun();
                Urun1.Id = 1;
                Urun1.UrunAd = "Masa";
                Urun1.UrunFiyat = 1000;
                Urun1.UrunTipi = "Ahşap Masa";

                Urun Urun2 = new Urun();
                Urun2.Id = 2;
                Urun2.UrunAd = "Halı";
                Urun2.UrunFiyat = 1200;
                Urun2.UrunTipi = "Yün Halı";

                Urun Urun3 = new Urun();
                Urun3.Id = 3;
                Urun3.UrunAd = "Tabak";
                Urun3.UrunFiyat = 50;
                Urun3.UrunTipi = "Porselen Tabak";

                Urun Urun4 = new Urun();
                Urun4.Id = 4;
                Urun4.UrunAd = "Tava";
                Urun4.UrunFiyat = 100;
                Urun4.UrunTipi = "Teflon Tava";

                Urun Urun5 = new Urun();
                Urun5.Id = 5;
                Urun5.UrunAd = "Televizyon";
                Urun5.UrunFiyat = 5000;
                Urun5.UrunTipi = "Smart TV";

                // classımızın türünde bir dizi tanımlayıp nesnelerimizi bu dizinin içine atıyoruz.

                Urun[] Uruns = new Urun[] { Urun1, Urun2, Urun3, Urun4, Urun5 };

                // for döngüsü ile ürünleri listeliyoruz.

                Console.WriteLine("***** For Döngüsü ile Listeleme *****");
                Console.WriteLine();

                for (int i = 0; i < Uruns.Length; i++)
                {
                    Console.WriteLine("Ürün ID          :" + Uruns[i].Id);
                    Console.WriteLine("Ürün Adı         :" + Uruns[i].UrunAd);
                    Console.WriteLine("Ürün Fiyatı      :" + Uruns[i].UrunFiyat);
                    Console.WriteLine("Ürün Açıklaması  :" + Uruns[i].UrunTipi);
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine();
                }

                // foreach döngüsü ile ürünleri listeliyoruz.

                Console.WriteLine("***** Foreach Döngüsü ile Listeleme *****");
                Console.WriteLine();

                foreach (var Urun in Uruns)
                {
                    Console.WriteLine("Ürün ID          :" + Urun.Id);
                    Console.WriteLine("Ürün Adı         :" + Urun.UrunAd);
                    Console.WriteLine("Ürün Fiyatı      :" + Urun.UrunFiyat);
                    Console.WriteLine("Ürün Açıklaması  :" + Urun.UrunTipi);
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine();
                }


// Urun adında bir class oluşturup, property'lerini tanımlıyoruz.
            class Urun
            {
                public int Id { get; set; }
                public string UrunAd { get; set; }
                public int UrunFiyat { get; set; }
                public string UrunTipi { get; set; }
            }
        }
	}
}
