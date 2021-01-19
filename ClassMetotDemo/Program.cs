using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 3301;
            musteri1.AdSoyad = "Hilal Taşkıran";
            musteri1.TelefonNo = 05341234569;
            musteri1.Adres = "Mersin";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 3302;
            musteri2.AdSoyad = "Şehmuz Kabadayı";
            musteri2.TelefonNo = 05331234569;
            musteri2.Adres = "Van";

           
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler )
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.AdSoyad);
                Console.WriteLine(musteri.TelefonNo);
                Console.WriteLine(musteri.Adres);
                Console.WriteLine("***********************************");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri2);
           



        }
    }
}
