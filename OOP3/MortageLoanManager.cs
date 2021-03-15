using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortageLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortage Loan payment plan calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
