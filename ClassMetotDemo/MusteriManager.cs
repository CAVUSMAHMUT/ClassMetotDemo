using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("musteriler eklendi: "+musteri.Adi);
            Console.WriteLine(musteri.Soyadi);
            Console.WriteLine(musteri.Id);
            Console.WriteLine("---------------------------------------");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("müşteriler listelendi: "+musteri.Adi);
            Console.WriteLine(musteri.Soyadi);
            Console.WriteLine(musteri.Id);
            Console.WriteLine("---------------------------------------");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("müşteriler silindi: " + musteri.Adi);
            Console.WriteLine(musteri.Soyadi);
            Console.WriteLine(musteri.Id);
            Console.WriteLine("---------------------------------------");
        }
    }
}
