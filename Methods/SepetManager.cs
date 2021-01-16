using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.. Sepete Eklendi: "+ urun.Adi);
        }

        public void Ekle2(string urunAdi,double fiyati,string aciklama,int stokAdedi)
        {
            Console.WriteLine("Tebrikler.. Sepete Eklendi: " + urunAdi);
        }
    }
}
