using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurslar",
                "Java Kursu",
                "Pyton Kursu",
                "C++ Kursu"
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs: "+ kurs);
            }

            Console.WriteLine("--------------");


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa sonu - footer");

        }
    }
}
