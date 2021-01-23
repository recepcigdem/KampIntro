using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager:ICreditManager
    {
        public void Calculation()
        {
            Console.WriteLine("Araç kredisi hesaplandı");
        }

        public void Exam()
        {
            Console.WriteLine("Örnek");
        }
    }
}
