﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager:ICreditManager
    {
        public void Calculation()
        {
            Console.WriteLine("Konut kredisi hesaplandı");
        }

        public void Exam()
        {
            Console.WriteLine("Örnek");
        }
    }
}
