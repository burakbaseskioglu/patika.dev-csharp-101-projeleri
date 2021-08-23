using System;
using System.IO;

namespace AtmApp
{
    public class FileLogger
    {
        //FileInfo fileInfo = new FileInfo("/Users/burakbaseskioglu/Documents/VSCode/patika.dev-csharp-101-projeleri/ZorSeviye/AtmApp/deneme.rtf");

        public static void CreateFile()
        {
            string filePath = FileDe();
            if (!File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
            }
            // string currentDirectory = Directory.GetCurrentDirectory();
            // string fullPath = currentDirectory + $"/EOD_{DateTime.Now.ToShortDateString()}";
            // FileStream fileStream = new FileStream(fullPath, FileMode.Create);
        }

        public static string FileDe()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fullPath = currentDirectory + $"/EOD{DateTime.Now.ToShortDateString()}.rtf";
            return fullPath;
        }

        public static void WriteFile()
        {
            string filePath = FileDe();
            FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter file = new StreamWriter(fileStream);
            var transactionList = TransactionHistory.Transactions;
            foreach (var item in transactionList)
            {
                file.WriteLine($"İşlem Sahibi:{item.Owner}\nTarih:{item.DateTime}\nİşlem Tipi:{item.OperationType}\nMiktar:{item.Amount}\n");
            }
            file.Close();
        }
    }
}