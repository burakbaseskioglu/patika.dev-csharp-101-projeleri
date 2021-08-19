using System;

namespace AlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen işlem yapmak istediğiniz geometrik şekli seçiniz.");
            Console.WriteLine("1 - Dikdörtgen");
            Console.WriteLine("2 - Kare");
            Console.WriteLine("3 - Üçgen");
            Console.WriteLine("4 - Çember");
            Console.Write("Seçiminiz:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DikdortgenHesaplama();
                    break;
                case 2:
                    KareHesaplama();
                    break;
                case 3:
                    UcgenHesapla();
                    break;
                case 4:
                    CemberHesapla();
                    break;
                default:
                    break;
            }
        }

        static int ChoiceMenu()
        {
            Console.WriteLine("1 - Alan Hesaplama");
            Console.WriteLine("2 - Çevre Hesaplama");
            Console.Write("Seçiminiz:");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static void DikdortgenHesaplama()
        {
            int choice = ChoiceMenu();

            Console.Write("Uzun kenar ölçüsünü giriniz:");
            int uzunKenar = int.Parse(Console.ReadLine());
            Console.Write("Kısa kenar ölçüsünü giriniz:");
            int kisaKenar = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Dikdörtgenin alanı {uzunKenar * kisaKenar} cm^2'dir");
                    break;
                case 2:
                    Console.WriteLine($"Dikdörtgenin çevresi {2 * (uzunKenar + kisaKenar)} cm'dir");
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ile 2 arasında bir seçim yapınız.");
                    break;
            }
        }

        static void KareHesaplama()
        {
            int choice = ChoiceMenu();

            Console.Write("Karenin kenar ölçüsünü giriniz:");
            int kenar = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Dikdörtgenin alanı {Math.Pow(kenar, 2)} cm^2'dir");
                    break;
                case 2:
                    Console.WriteLine($"Dikdörtgenin çevresi {4 * kenar} cm'dir");
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ile 2 arasında bir seçim yapınız.");
                    break;
            }
        }

        static void UcgenHesapla()
        {
            int choice = ChoiceMenu();

            switch (choice)
            {
                case 1:
                    Console.Write("Üçgenin taban ölçüsünü giriniz:");
                    int taban = int.Parse(Console.ReadLine());
                    Console.Write("Üçgenin yüksekliğini giriniz:");
                    int yukseklik = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Üçgenin alanı {(taban * yukseklik) / 2} cm^2'dir");
                    break;
                case 2:
                    Console.Write("Üçgenin taban ölçüsünü giriniz:");
                    int kenar1 = int.Parse(Console.ReadLine());
                    Console.Write("Üçgenin yüksekliğini giriniz:");
                    int kenar2 = int.Parse(Console.ReadLine());
                    Console.Write("Üçgenin yüksekliğini giriniz:");
                    int kenar3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Üçgenin çevresi {kenar1 + kenar2 + kenar3} cm'dir");
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ile 2 arasında bir seçim yapınız.");
                    break;
            }
        }
        static void CemberHesapla()
        {
            int choice = ChoiceMenu();
            Console.Write("Yarıçapı giriniz:");
            int r = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Çemberin alanı {Math.PI * (Math.Pow(r, 2))} cm^2'dir");
                    break;
                case 2:
                    Console.WriteLine($"Çemberin çevresi {2 * (Math.PI * r)} cm'dir");
                    break;
                default:
                    Console.WriteLine("Lütfen 1 ile 2 arasında bir seçim yapınız.");
                    break;
            }
        }
    }
}
