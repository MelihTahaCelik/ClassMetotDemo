using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1= new Musteri();
            musteri1.Ad = "Melih Taha";
            musteri1.Soyad = "Çelik";
            musteri1.Yas =21;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ahmet İlhan";
            musteri2.Soyad = "Sarı";
            musteri2.Yas = 39;

            Console.WriteLine("--------------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            musteriManager.Listeleme(musteriler);












        }
    }
}
