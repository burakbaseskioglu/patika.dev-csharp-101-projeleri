using System;
using System.Linq;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen oylamak istediğiniz kategoriyi seçiniz.");
            var categoryList = CategoryDataSource.CategoryList;
            for (int i = 0; i < categoryList.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {categoryList[i].Name}");
            }
    
            int choice2 = 0;
            do
            {
                Console.Write("Seçiminiz:");
                choice2 = int.Parse(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        CategoryVote("Film");
                        break;
                    case 2:
                        CategoryVote("Müzik");
                        break;
                    case 3:
                        CategoryVote("Tech Stack");
                        break;
                    case 4:
                        CategoryVote("Müzik");
                        break;
                }
            } while (choice2 >= 1 && choice2 < 5);

            CategoryList();
            CalcVote();
        }

        static bool CheckUserControl()
        {
            Console.Write("Lütfen oy kullanabilmek için kullanıcı adınızı giriniz:");
            string userName = Console.ReadLine();

            var user = UserDataSource.UserList.Find(x => x.UserName == userName);
            if (user == null)
            {
                AddUser();
            }

            return true;
        }

        static void CategoryVote(string categoryName)
        {
            var result = CheckUserControl();

            if (result == true)
            {
                var category = CategoryDataSource.CategoryList.Find(x => x.Name == categoryName);
                category.Vote += 1;
                Console.WriteLine($"Oyunuz {category.Name} kategorisine başarılı bir şekilde eklenmiştir.");
            }
        }

        static void AddUser()
        {
            Console.WriteLine("Sistemde kayıtlı üyeliğiniz bulunmamaktadır.");
            Console.WriteLine("Üye olmak istiyor musunuz?");
            Console.WriteLine("1 - Evet\n2 - Hayır");
            Console.Write("Seçiminiz:");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Lütfen kullanıcı adı giriniz:");
                string userName = Console.ReadLine();
                Console.Write("Lütfen ad ve soyad giriniz:");
                string fullName = Console.ReadLine();
                UserDataSource.UserList.Add(new User(userName, fullName));
            }
        }

        static void CategoryList()
        {
            foreach (var item in CategoryDataSource.CategoryList)
            {
                Console.WriteLine($"{item.Name} kategorisi oy sayısı: {item.Vote}");
            }
        }

        static void CalcVote()
        {
            float category1Vote = CategoryDataSource.CategoryList.Find(x => x.Name == "Film").Vote;
            float category2Vote = CategoryDataSource.CategoryList.Find(x => x.Name == "Müzik").Vote;
            float category3Vote = CategoryDataSource.CategoryList.Find(x => x.Name == "Tech Stack").Vote;
            float category4Vote = CategoryDataSource.CategoryList.Find(x => x.Name == "Spor").Vote;

            float category1Sum = 0;
            float category2Sum = 0;
            float category3Sum = 0;
            float category4Sum = 0;
            category1Sum = (category1Vote / (category1Vote + category2Vote + category3Vote + category4Vote)) * 100;
            category2Sum = (category2Vote / (category1Vote + category2Vote + category3Vote + category4Vote)) * 100;
            category3Sum = (category3Vote / (category1Vote + category2Vote + category3Vote + category4Vote)) * 100;
            category4Sum = (category4Vote / (category1Vote + category2Vote + category3Vote + category4Vote)) * 100;

            Console.WriteLine($"Film Kategorisi %{Math.Round(category1Sum, 2)} oy");
            Console.WriteLine($"Müzik KAtegorisi %{Math.Round(category2Sum, 2)} oy");
            Console.WriteLine($"Tech Stack Kategorisi %{Math.Round(category3Sum, 2)} oy");
            Console.WriteLine($"Spor Kategorisi {Math.Round(category4Sum, 2)} oy");
        }
    }
}
