using System;

namespace OOP3
{
    class ArtificerCreditManager : ICreditManager
    {
        public void Calculation()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void Exam()
        {
            Console.WriteLine("Örnek");
        }
    }
}