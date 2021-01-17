using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle()
        {
            Console.WriteLine("Musteri eklendi.");
        }
        public void Sil()
        {
            Console.WriteLine("Musteri silindi");
        }
        public void Listele(Array musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.UyeNumarası);
                Console.WriteLine("----------------------------");
            }

        }
    }
}
