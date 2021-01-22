using System;

namespace donguler
{
	class Program
	{
		static void Main(string[] args)
		{

			string kurs1 = "Yazılım geliştirme Kampı";
			string kurs2 = "Programlamaya Başlangıç için Temel kurs";
			string kurs3 = "java Gelişim";

			string[] kurslar = new string[] { "Yazılım geliştirme " +
				"Kampı", "Programlamaya Başlangıç için Temel " +
				"kurs","java Gelişim","python" };

			for (int i = 0; i <kurslar.Length; i++)
			{
				Console.WriteLine(kurslar[i]);
			}

			Console.WriteLine("for bitti");

			foreach (string kurs in kurslar)
			{
				Console.WriteLine(kurs);
			}

			Console.WriteLine("Sayfa sonu - - - Footer");

		}
	}
}
