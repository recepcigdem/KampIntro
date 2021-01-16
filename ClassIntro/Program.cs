using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.Adi = "C#";
            kurs1.Egitmen = "Recep Çiğdem";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Adi = "Java";
            kurs2.Egitmen = "Recep Çiğdem";
            kurs2.IzlenmeOrani = 85;

            Kurs kurs3 = new Kurs();
            kurs3.Adi = "C++";
            kurs3.Egitmen = "Recep Çiğdem";
            kurs3.IzlenmeOrani = 78;

            Kurs kurs4 = new Kurs();
            kurs4.Adi = "Pyton";
            kurs4.Egitmen = "Yavuz Çiğdem";
            kurs4.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,
                kurs2,
                kurs3,
                kurs4
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı: "+ kurs.Adi + " Eğitmen: " + kurs.Egitmen + " İzlenme Oranı: " + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string Adi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
