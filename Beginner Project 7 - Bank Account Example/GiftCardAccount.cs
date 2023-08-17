using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_7
{
    public class GiftCardAccount : BankAccount //this is inheritance, the dervied classes have the same behaviour as the base class
    {
        //constructor is reposnible for initialising a object, derived class constructor must initialise derived class
        //it must also provide instructions on how to initialise base c;ass object included in the derived class

        //BankAccount class already has a constructor with its own signature, each derived class must explicitly call the base class constructor
        //this is done through declaring a constructor in the dervied class which can pass arguements in the base class constructor

        private decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string nameGFA, decimal initialBalanceGFA, decimal monthlyDeposit = 0) : base(nameGFA, initialBalanceGFA) //this is example of a derived constructor passing arguements to base constructor
            => _monthlyDeposit = monthlyDeposit;
        //notice how this derived constructor method does not have {}
        //a new private variable is added and the contructor is edited
        //the derived constructor has 1 more arguement that the base constructor doesnt have, and it is assigned a default value
        //the => is a specific operator in C#. it has 2 uses, in this case it use an 'expression body definition'
        //in this definition is a shorthand for a returned value, it is taking a public property 'monthlyDeposit' and assinging it to  private property '_monthlydeposit'

        public void printMonthlyDeposit()
        {
            Console.WriteLine($"This class' private variable is: {_monthlyDeposit}");
        }

        public override void PerformMonthEndTransaction()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add Monthly Deposit");
            }
        }
    }
}
