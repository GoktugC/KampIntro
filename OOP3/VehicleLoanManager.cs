﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Loan payment plan calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
