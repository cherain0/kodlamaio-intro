using System;

namespace kodlamaio_intro
{
	class Program
	{
		static void Main(string[] args)
		{
			string kategoriEtiketi = "Kategori";
			int ogrenciSayisi = 32000;
			bool sistemeGirisYapmisMi = true;
			double dolarDun = 7.35;
			double dolarBugun = 7.45;

			if (dolarDun>dolarBugun)
			{
				Console.WriteLine("Azalış butonu");
			}
			else if (dolarDun<dolarBugun)
			{
				Console.WriteLine("Artış butonu");
			}
			else
			{
				Console.WriteLine("Değişmedi Butonu");
			}
			if (sistemeGirisYapmisMi == true)
			{
				Console.WriteLine("Ayarlar");
			}
			else 
			{
				Console.WriteLine("Giriş Yap Butonu");
			}
			Console.WriteLine(kategoriEtiketi);
		}	
	}
}