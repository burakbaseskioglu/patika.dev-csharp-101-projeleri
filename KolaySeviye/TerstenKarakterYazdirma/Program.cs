using System;

namespace TerstenKarakterYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İfade giriniz:");
            string expression = Console.ReadLine();

            Console.WriteLine(WriteFirstCharacterLast(expression));
        }

        static string WriteFirstCharacterLast(string expression)
        {
            char firstCharacter = expression[0];
            return expression.Substring(1, expression.Length - 1) + firstCharacter;
        }
    }
}
