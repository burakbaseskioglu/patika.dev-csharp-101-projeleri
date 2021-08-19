using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Virgüllü ifadeyi giriniz:");
            string str = Console.ReadLine();
            Console.WriteLine(DeleteCharacter(str));
        }

        static string DeleteCharacter(string expression)
        {
            string[] strArr = expression.Split(',');
            int index = int.Parse(strArr[1].Trim());
            return strArr[0].Remove(index, 1);
        }
    }
}
