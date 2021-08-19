using System;

namespace OrtalamaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            double toplam = 0;
            Console.Write("Fibonacci dizisi kaç elemanlı olsun? :");
            int boyut = int.Parse(Console.ReadLine());

            for (int i = 0; i < boyut; i++)
            {   
                toplam = toplam + Toplam(sayi);
                //Console.WriteLine(Toplam(sayi));
                sayi++;
            }
            Console.WriteLine($"Fibonacci dizisinin ortalaması {toplam / boyut}");
        }

        static int Toplam(int sayi)
        {
            if (sayi == 0)
            {
                return 0;
            }
            else if (sayi == 1)
            {
                return 1;
            }
            else
            {
                return Toplam(sayi - 1) + Toplam(sayi - 2);
            }
        }
    }
}
