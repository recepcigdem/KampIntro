using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager
    {
        public void DoAppeal(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculation();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void DoInfoByCredit(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculation();
            }
        }
    }
    
}
