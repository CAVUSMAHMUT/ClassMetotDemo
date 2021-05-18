using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "mahmut";
            musteri1.Soyadi = "çavuş";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "hüseyin";
            musteri2.Soyadi = "çavuş";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "muarrem";
            musteri3.Soyadi = "çavuş";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);

        }
    }
}
