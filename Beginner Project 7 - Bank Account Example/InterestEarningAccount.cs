using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_7
{
    public class InterestEarningAccount : BankAccount //this is inheritance, the dervied classes have the same behaviour as the base class
    {
        //constructor is reposnible for initialising a object, derived class constructor must initialise derived class
        //it must also provide instructions on how to initialise base c;ass object included in the derived class

        //BankAccount class already has a constructor with its own signature, each derived class must explicitly call the base class constructor
        //this is done through declaring a constructor in the dervied class which can pass arguements in the base class constructor

        public InterestEarningAccount(string nameIEA, decimal initialBalanceIEA) : base(nameIEA, initialBalanceIEA) //this is example of a derived constructor passing arguements to base constructor
        {

        }

        public override void PerformMonthEndTransaction()
        {//where the keywords 'virtual' or 'abstract' are used in base class for polymorphism, 'override' is needed in derived class to override that implementation
            if (Balance > 500m)
            {
                var interest = Balance * .05m;
                MakeDeposit(interest, DateTime.Now, "Monthly Interest!");
            }
        }
    }
}
