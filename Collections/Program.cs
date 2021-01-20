using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Recep", "Yavuz", "Aygün"};
            //foreach (string isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            //isimler = new string[5];
            //isimler[4] = "Yusuf";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            
            
            
            List<string> isimler2 = new List<string>() { "Recep", "Yavuz", "Aygün" };
            foreach (var isim in isimler2)
            {
                Console.WriteLine(isim);
            }
            isimler2.Add("Yusuf");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
