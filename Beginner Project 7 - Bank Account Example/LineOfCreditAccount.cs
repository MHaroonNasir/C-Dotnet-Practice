using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_7
{
    public class LineOfCreditAccount : BankAccount //this is inheritance, the dervied classes have the same behaviour as the base class
    {
        //constructor is reposnible for initialising a object, derived class constructor must initialise derived class
        //it must also provide instructions on how to initialise base c;ass object included in the derived class

        //BankAccount class already has a constructor with its own signature, each derived class must explicitly call the base class constructor
        //this is done through declaring a constructor in the dervied class which can pass arguements in the base class constructor

        public LineOfCreditAccount(string nameLCA, decimal initialBalanceLCA) : base(nameLCA, initialBalanceLCA) //this is example of a derived constructor passing arguements to base constructor
        {

        }

        public override void PerformMonthEndTransaction()
        {
            if (Balance < 0)
            {
                var interest = -Balance * .07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge Monthly Interest");
            }
        }
    }
}
