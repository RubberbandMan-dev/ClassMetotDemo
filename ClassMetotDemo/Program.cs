using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet Berat";
            musteri1.Soyad = "Kahraman";
            musteri1.UyeNumarası = 001;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.UyeNumarası = 002;

            MusteriManager musterimanager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            Console.WriteLine("Hoşgeldiniz. Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("Müşteri eklemek için -1-");
            Console.WriteLine("Müşteri silmek için -2-");
            Console.WriteLine("Müşteri listelemek için -3-");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    musterimanager.Ekle();
                    break;
                case "2":
                    musterimanager.Sil();
                    break;
                case "3":
                    musterimanager.Listele(musteriler);
                    break;
            }
        }
    }
}
