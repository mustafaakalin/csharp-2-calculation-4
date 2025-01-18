using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kontrol mekanizması switch case (durum kontrolü)
            start:
            Console.WriteLine("Lütfen 1. sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen bir işlem seçiniz: ");
            string islem = Console.ReadLine();

            switch (islem)
            {
                case "+":
                    Console.WriteLine("Toplama işlemi sonucu: " + (sayi + sayi1));
                    break;
                case "-":
                    Console.WriteLine("Çıkarma işlemi sonucu: " + (sayi - sayi1));
                    break;
                case "*":
                    Console.WriteLine("Çarpma işlemi sonucu: " + (sayi * sayi1));
                    break;
                case "/":
                    Console.WriteLine("Bölme işlemi sonucu: " + (sayi / sayi1));
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem");
                    break;
            }

            // Console.WriteLine("Hello World!");
        }
    }
}