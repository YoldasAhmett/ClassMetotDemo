using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1111;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Kalkan";
            musteri1.TcNo = "12345678";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1112;
            musteri2.Ad = "Hasan";
            musteri2.Soyad = "Kurt";
            musteri2.TcNo = "12345679";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1113;
            musteri3.Ad = "Zehra";
            musteri3.Soyad = "Bilmez";
            musteri3.TcNo = "12345670";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekleme(musteriler);
            musteriManager.Silme(musteriler);
            musteriManager.Listeleme(musteriler);
            Console.ReadKey();
        }
    }
}
