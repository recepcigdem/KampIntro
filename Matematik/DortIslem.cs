using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    public class DortIslem
    {
        private int sonuc;

        public void Topla(int sayi1, int sayi2)
        {
            sonuc = sayi1 + sayi2;

            Console.WriteLine("Sonuç: "+ sonuc);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
        }

        public void Carp(int sayi1, int sayi2)
        {
            sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
        }

        public void Bol(int sayi1, int sayi2)
        {
            sonuc = sayi1 / sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
        }
    }
}
