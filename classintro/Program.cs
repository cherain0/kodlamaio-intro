using System;

namespace classintro
{
	class Program
	{
		static void Main(string[] args)
		{
			string adı = "cherain";
			int yas = 23;

			kurs  kurs1 = new kurs();
			kurs1.kursAdı = "C#";
			kurs1.Egitmen = "cherain";
			kurs1.IzlenmeOranı = 68;

			kurs kurs2 = new kurs();
			kurs2.kursAdı = "java";
			kurs2.Egitmen = "che";
			kurs2.IzlenmeOranı = 67;

			kurs kurs3 = new kurs();
			kurs3.kursAdı = "python";
			kurs3.Egitmen = "chera";
			kurs3.IzlenmeOranı = 65;

			//Console.WriteLine(kurs1.kursAdı + "  :" + kurs1.Egitmen);

			kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };

			foreach (var kurs in kurslar)
			{
				Console.WriteLine(kurs.kursAdı + " : " + kurs.Egitmen);
			}

			//Console.WriteLine("Hello World!");
		}
	}

	class kurs
	{
		public string kursAdı { get; set; }

		public string Egitmen { get; set; }
		public int IzlenmeOranı { get; set; }
	}
}
