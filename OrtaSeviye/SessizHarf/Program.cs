using System;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelime giriniz:");
            string word = Console.ReadLine();

            bool result = CheckWord(word);
            Console.WriteLine(result);
        }

        static bool CheckWord(string word)
        {
            bool isSuccess = false;
            int j = 1;
            for (int i = 0; i < word.Length; i++)
            {
                if (j == word.Length)
                {
                    break;
                }
                if (IsConsonant(word[i]) == true && IsConsonant(word[j]) == true)
                {
                    isSuccess = true;
                    break;
                }
                j++;
            }

            return isSuccess;
        }

        static bool IsConsonant(char character)
        {
            bool result = false;
            char[] arrLetter = { 'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z' };
            for (int i = 0; i < arrLetter.Length; i++)
            {
                if (character == arrLetter[i])
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
