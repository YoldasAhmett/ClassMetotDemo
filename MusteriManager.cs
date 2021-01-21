using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "eklendi!");
            }
            Console.WriteLine("\n");
        }
        public void Silme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "silindi!");

            }
            Console.WriteLine("\n");
        }

        public void Listeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri Id: " + musteri.Id + "\n" + "Tc No: " + musteri.TcNo + "\n" +
                    "Musteri Ad Soyad:" + musteri.Ad + " " + musteri.Soyad + "\n");
            }
            Console.WriteLine("\n");
        }
    }
}
