using System;
using System.IO;

namespace AtmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                MenuList();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CustomerManager.WithDrawal();
                        break;
                    case 2:
                        CustomerManager.Deposit();
                        break;
                    case 3:
                        CustomerManager.BalanceViewing();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Lütfen 1 ile 4 arasında bir seçim yapınız!");
                        break;
                }
            } while (choice >= 1 && choice < 4);

            // var TransactionList = TransactionHistory.Transactions;
            // foreach (var item in TransactionList)
            // {
            //     Console.WriteLine($"İşlem Sahibi:{item.Owner}\nTarih:{item.DateTime}\nİşlem Tipi:{item.OperationType}\nMiktar:{item.Amount}");
            // }
            FileLogger.WriteFile();
        }

        static void MenuList()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("1 - Para Çekme");
            Console.WriteLine("2 - Para Yatırma");
            Console.WriteLine("3 - Bakiye Görüntüleme");
            Console.WriteLine("4 - Çıkış");
            Console.Write("Seçiminiz:");
        }
    }
}
