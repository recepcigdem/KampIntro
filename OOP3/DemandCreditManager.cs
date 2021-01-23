using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DemandCreditManager:ICreditManager
    {
        public void Calculation()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");
        }

        public void Exam()
        {
            Console.WriteLine("Örnek");
        }
    }
}
