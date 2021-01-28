using System;

namespace YazilimKampi3gOdev2OutOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
			Out o = new Out();
			int a, b;
			a = o.Sayi(10, out b);
            Console.WriteLine("------------ OUT kullanımı ---------------------");
			Console.WriteLine("Üçe bölünen sayısı: " + a);
			Console.WriteLine("Beşe bölünen sayısı: " + b);
		}
    }
	class Out
	{
		int uc, bes = 0;
		public int Sayi(int n, out int sayi)
		{
			for (int i = 1; i <= n; i++)
			{

				if (i % 3 == 0)
					uc++;

				if (i % 5 == 0)
					bes++;
			}
			sayi = bes;
			return uc;
		}
	}

}
