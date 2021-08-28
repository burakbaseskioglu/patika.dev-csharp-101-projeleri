using System;
using System.Drawing;
using ZXing;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ne yapmak istiyorsunuz?");
            Console.WriteLine("1 - Barkod okutmak");
            Console.WriteLine("2 - Barkod oluşturmak");
            Console.Write("Seçiminiz:");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BarcodeReader();
            }
            else if (choice == 2)
            {
                BarcodeWriter();
            }
            else
            {
                Console.WriteLine("Lütfen 1 veya 2 arasında bir seçim yapınız!");
            }
        }

        static string SelectFile()
        {
            Console.Write("Dosya yolunu giriniz:");
            string filePath = Console.ReadLine();
            return filePath;
        }

        static void BarcodeReader()
        {
            var filePath = SelectFile();
            BarcodeReader barcodeReader = new BarcodeReader();
            var barcodeBitmap = (Bitmap)Image.FromFile(filePath);
            var result = barcodeReader.Decode(barcodeBitmap);

            if (result != null)
            {
                Console.WriteLine(result.Text);
            }
        }

        static void BarcodeWriter()
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Write("https://www.google.com/").Save("/Users/burakbaseskioglu/Documents/VSCode/patika.dev-csharp-101-projeleri/ZorSeviye/BarcodeGenerator/image/yeni2.png");
        }

        static void Save(Bitmap bitmapSource)
        {
            // Image dummy = Image.FromFile("/Users/burakbaseskioglu/Documents/VSCode/patika.dev-csharp-101-projeleri/ZorSeviye/BarcodeGenerator/image/myqrcode.png");
            // dummy.Save("myqrcode.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}