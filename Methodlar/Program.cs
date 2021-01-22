﻿using System;

namespace Methodlar
{
	class Program
	{
		static void Main(string[] args)
		{



			Urun urun1 = new Urun();
			urun1.Adi = "Elma";
			urun1.Fiyati = 15;
			urun1.Aciklama = "Amasya Elması";

			Urun urun2 = new Urun();
			urun2.Adi = "Karpuz";
			urun2.Fiyati = 88;
			urun2.Aciklama = "Diyarbakır Karpuzu";

			Urun[] urunler = new Urun[] {urun1,urun2 };

			foreach (Urun urun in urunler)
			{
				Console.WriteLine(urun.Adi);
				Console.WriteLine(urun.Fiyati);
				Console.WriteLine(urun.Aciklama);
				Console.WriteLine("---------0000000000000------------");
			}

			Console.WriteLine("-------------methodlar-----------");

			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(urun1);
			sepetManager.Ekle(urun2);

		}
	}
}