﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme.
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditPreNotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
