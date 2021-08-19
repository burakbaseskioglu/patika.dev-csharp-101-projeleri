using System;

namespace UcgenCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgen kaç katlı olsun? :");
            int floorNumber = int.Parse(Console.ReadLine());

            DrawTriangle(floorNumber);
        }
        static void DrawTriangle(int floorNumber)
        {
            for (int i = 1; i <= floorNumber; i++)
            {
                for (int j = i; j < floorNumber; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
