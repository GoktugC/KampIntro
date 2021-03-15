using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ConsumerLoanManager = new ConsumerLoanManager();
            ICreditManager VehicleLoanManager = new VehicleLoanManager();
            ICreditManager MortageLoanManager = new MortageLoanManager();
            ICreditManager ArtisanLoanManager = new ArtisanLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(ArtisanLoanManager, loggers);
            List<ICreditManager> credits = new List<ICreditManager>() {ConsumerLoanManager, VehicleLoanManager};

            //applicationManager.CreditPreNotification(credits);
        }
    }
}
