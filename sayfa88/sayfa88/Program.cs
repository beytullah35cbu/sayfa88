using System;
namespace or211
{
    class Program
    //en yüksek ve en düşük notu alan birden fazla kişi varsa onların da isimlerini yazdırınız.
    {
        public static void Main(string[] args)
        {
            string[] isimler = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] notlar = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 33 };

            int enBuyuk = int.MinValue;
            int enDusuk = int.MaxValue;

            Console.WriteLine("En Yüksek Notu Alan Kişiler");

            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > enBuyuk)
                {
                    enBuyuk = notlar[i]; //bırden fazla en yuksek notları ekle
                }
            }

            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] == enBuyuk)
                {
                    Console.WriteLine(isimler[i]); //en yuksek notu yaz veya sadece yuksek not
                }
            }

            Console.WriteLine("\nEn Düşük Notu Alan Kişiler");

            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < enDusuk)
                {
                    enDusuk = notlar[i];//dusuklerı ekle
                }
            }

            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] == enDusuk)
                {
                    Console.WriteLine(isimler[i]);
                }
            }

            Console.ReadKey();



        }
    }
}