﻿using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //do not repeat yourself - kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu göster");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu göster");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullıcı ayarları butonu!");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
