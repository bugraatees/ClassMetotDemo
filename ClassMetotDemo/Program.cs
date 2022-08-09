using ClassMetotDemo;
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Müşteri BİLGİLERİ------");
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Saygın";


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Kamil";
            musteri2.Soyadi = "Zorlu";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
            }
            Console.WriteLine("-------Müşteri Ekleme------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("------Müşteri Listeleme------");
            musteriManager.Liste(musteri1);
            musteriManager.Liste(musteri2);


            Console.WriteLine("-----Müşteri Silme-----");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);


        }
    }
}
