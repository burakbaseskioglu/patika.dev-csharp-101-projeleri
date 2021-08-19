using System;

namespace KarakterDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelimeyi giriniz:");
            string word = Console.ReadLine();
            string cutWord = word.Substring(1, word.Length - 2);
            Console.WriteLine(word[word.Length - 1] + cutWord + word[0]);
        }
    }
}
