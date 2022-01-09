using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Ad:" + musteri.Ad + "\tSoyad:" + musteri.Soyad + "\tYAŞI:" + musteri.Yas + "\nMüsteriler Eklendi");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Ad:" + musteri.Ad + "\tSoyad:" + musteri.Soyad + "\tYAŞI:" + musteri.Yas + "\nMüşteriler Silindi");
        }


        public void Listeleme(Musteri[] musteriler) 
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı:"+musteri.Ad);
                Console.WriteLine("Müşteri Soyadı:" + musteri.Soyad);
                Console.WriteLine("Müşteri Yaşı:" + musteri.Yas);

            }
        }

    }
}
