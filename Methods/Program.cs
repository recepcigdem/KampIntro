using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Çilek";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Kırmızı çilek";
            urun2.StokAdedi = 15;

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı: "+ urun.Adi);
                Console.WriteLine("Fiyatı: " + urun.Fiyati);
                Console.WriteLine("Açıklaması: " + urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------Methodlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Karpuz",70,"Diyarbakır karpuzu",20);
        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice
