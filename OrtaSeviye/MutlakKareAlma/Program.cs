using System;
using System.Collections.Generic;

namespace MutlakKareAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizi boyutunu giriniz:");
            int arrLength = int.Parse(Console.ReadLine());

            List<int> kucukOlanlar = new List<int>();
            List<int> buyukOlanlar = new List<int>();

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi < 67)
                {
                    kucukOlanlar.Add(sayi);
                }
                else if (sayi > 67)
                {
                    buyukOlanlar.Add(sayi);
                }
            }
            CalcLessThanSixtySeven(kucukOlanlar);
            CalcMoreThanSixtySeven(buyukOlanlar);
        }

        static void CalcLessThanSixtySeven(List<int> numberList)
        {
            int result = 0;
            foreach (var item in numberList)
            {
                result = result + (67 - item);
            }
            Console.WriteLine($"67 küçük olan sayıların farklarının toplamı={result}");
        }

        static void CalcMoreThanSixtySeven(List<int> numberList)
        {
            int result = 0;
            foreach (var item in numberList)
            {
                result = result + (int)Math.Pow((item - 67), 2);
            }
            Console.WriteLine($"67'den büyük sayıların farklarının karesi={result}");
        }
    }
}
