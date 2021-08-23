using System;

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
                        CustomerManager.GetBalance();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Lütfen 1 ile 4 arasında bir seçim yapınız!");
                        break;
                }
            } while (choice >= 1 && choice < 4);

            foreach (var item in TransactionHistory.Transactions)
            {
                if (item.Amount == 0)
                {
                    Console.WriteLine($"İşlem Zamanı:{item.DateTime}\nİşlem Sahibi:{item.Owner}\nİşlem Tipi:{item.OperationType}\n");
                }
                else
                {
                    Console.WriteLine($"İşlem Zamanı:{item.DateTime}\nİşlem Sahibi:{item.Owner}\nİşlem Miktarı:{item.Amount}\nİşlem Tipi:{item.OperationType}\n");
                }

            }
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