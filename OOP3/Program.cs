using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager demandCreditManager = new DemandCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager artificerCreditManager = new ArtificerCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            //ILoggerService smsLoggerService = new SmsLoggerService();

            AppealManager appealManager = new AppealManager();
            appealManager.DoAppeal(artificerCreditManager,new List<ILoggerService>(){databaseLoggerService,new SmsLoggerService()});

            List<ICreditManager> credits = new List<ICreditManager>() { demandCreditManager,vehicleCreditManager};

            //appealManager.DoInfoByCredit(credits);
        }
    }
}
