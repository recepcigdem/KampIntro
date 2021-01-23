using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek kişi
            Individual individual1 = new Individual();

            individual1.Id = 1;
            individual1.CustomerNumber = "12345";
            individual1.FirstName = "Recep";
            individual1.LastName = "Çiğdem";
            individual1.IdentityNumber = "234565567567";

            //Tüzel Kişi
            Coorporate coorporate1 = new Coorporate();

            coorporate1.Id = 2;
            coorporate1.CustomerNumber = "544312";
            coorporate1.CompanyName = "RecepÇiğdem A.Ş";
            coorporate1.TaxNo = "1233243676567";


            Customer customer4 = new Individual();

            Customer customer3 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individual1);
            customerManager.Add(coorporate1);

        }
    }
}
