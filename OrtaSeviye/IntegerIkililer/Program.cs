using System;
using System.Collections.Generic;

namespace IntegerIkililer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizi boyutunu giriniz:");
            int arrLength = int.Parse(Console.ReadLine());

            List<int> numberList = new List<int>();

            for (int i = 0; i < arrLength; i++)
            {
                string[] strArr = Console.ReadLine().Split();
                int num1 = int.Parse(strArr[0]);
                int num2 = int.Parse(strArr[1]);

                int result = Process(num1, num2);
                numberList.Add(result);
            }
            GetNumberList(numberList);
        }

        static void GetNumberList(List<int> numberList)
        {
            Console.WriteLine("****");
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }
        }

        static int Process(int numberOne, int numberTwo)
        {
            if (numberOne == numberTwo)
            {
                int sum = numberOne + numberTwo;
                int result = Convert.ToInt32(Math.Pow(sum, 2));
                return result;
            }
            return numberOne + numberTwo;
        }
    }
}