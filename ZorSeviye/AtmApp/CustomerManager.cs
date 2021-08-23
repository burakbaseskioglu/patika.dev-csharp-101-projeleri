using System;
using System.Linq;

namespace AtmApp
{
    public static class CustomerManager
    {
        public static Customer Login()
        {
            short customerPassword = 0;
            Customer customer;
            do
            {
                Console.Write("Şifrenizi giriniz:");
                customerPassword = short.Parse(Console.ReadLine());

                customer = CustomerDataSource.CustomerList.Find(x => x.Password == customerPassword);
                if (customer != null)
                {
                    return customer;
                }
                Console.WriteLine("Şifreniz hatalı");
            } while (customer == null);

            return null;
        }

        public static void WithDrawal()
        {
            var customer = Login();
            if (customer != null)
            {
                Console.WriteLine($"Hoşgeldiniz {customer.FullName}");
                Console.Write("Çekme istediğiniz miktar:");
                double amount = double.Parse(Console.ReadLine());

                if (amount > customer.Balance)
                {
                    Console.WriteLine("Yetersiz bakiye");
                }
                else
                {
                    customer.Balance -= amount;
                    Console.WriteLine("Yeni bakiyeniz {0:C}", customer.Balance);

                    TransactionHistory.Transactions.Add(
                        new Transaction
                        {
                            Owner = customer.FullName,
                            Amount = amount,
                            OperationType = Operation.ParaCekme
                        });
                }
            }
        }

        public static bool ConfirmMenu()
        {
            Console.Write("Onaylıyor musunuz?(e-h):");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'e')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Deposit()
        {
            var customer = Login();
            Console.WriteLine($"Hoşgeldiniz {customer.FullName}");
            Console.Write("Yatırmak istediğiniz miktar:");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Yatırmak istediğiniz miktar {0:C}", amount);
            bool result = ConfirmMenu();

            if (result == true)
            {
                customer.Balance += amount;
                Console.WriteLine();
                Console.WriteLine("*************************");
                Console.WriteLine("Yeni bakiyeniz {0:C}", customer.Balance);
                Console.WriteLine("*************************");
                Console.WriteLine();
                TransactionHistory.Transactions.Add(
                        new Transaction
                        {
                            Owner = customer.FullName,
                            Amount = amount,
                            OperationType = Operation.ParaYatirma
                        });
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("*********************************");
                Console.WriteLine("Para yatırma işlemi iptal edildi.");
                Console.WriteLine("*********************************");
                Console.WriteLine();
            }
        }

        public static void BalanceViewing()
        {
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine();
            var customer = Login();
            Console.WriteLine($"Hoşgeldiniz {customer.FullName}");
            Console.WriteLine("Hesap bakiyeniz {0:C}", customer.Balance);
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine();
        }
    }
}