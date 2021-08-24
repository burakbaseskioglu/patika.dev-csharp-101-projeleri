using System;
using System.IO;

namespace AtmApp
{
    public class FileLogger
    {
        public static void CreateFile()
        {
            string filePath = CreateFilePath();
            if (!File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
            }
        }

        public static string CreateFilePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fullPath = currentDirectory + $"/EOD{DateTime.Now.ToShortDateString()}.rtf";
            return fullPath;
        }

        public static void WriteFile()
        {
            string filePath = CreateFilePath();
            FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter file = new StreamWriter(fileStream);
            var transactionList = TransactionHistory.Transactions;
            foreach (var item in transactionList)
            {
                if (item.Amount == 0)
                {
                    Console.WriteLine($"İşlem Zamanı:{item.DateTime}\nİşlem Sahibi:{item.Owner}\nİşlem Tipi:{item.OperationType}\n");
                }
                else
                {
                    file.WriteLine($"İşlem Sahibi:{item.Owner}\nTarih:{item.DateTime}\nİşlem Tipi:{item.OperationType}\nMiktar:{item.Amount:C}\n");
                }
            }
            file.Close();
        }
    }
}