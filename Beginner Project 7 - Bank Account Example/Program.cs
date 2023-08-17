using System;

namespace Beginner_Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var account0 = new BankAccount("TestName1", 1000); //declaration of a new object named 'account0' of 'BankAccount' class specified in other file, passing 2 variables asked by constructor
            Console.WriteLine($"Name: {account0.Owner}, Balance: {account0.Balance}, Number: {account0.AccountNumber}");
            //notice all field of this object that are immediately accesible are those properties labelled as 'public' in the other file
            account0.MakeDeposit(50, DateTime.Now, "Deposit");
            account0.MakeWithdrawal(100, DateTime.Now, "Withdrawal");
            Console.WriteLine($"Owner name: {account0.Owner}, Owner Number: {account0.AccountNumber}, Owner Balance: {account0.Balance}");

            //account0.MakeDeposit(0, DateTime.Now, "Attempting at null deposit.");
            //account0.MakeWithdrawal(1500, DateTime.Now, "Attempting overdraft.");
            //the first exception detected will terminate the program

            var account2 = new GiftCardAccount("GiftAccountName000", 1000);
            account2.printMonthlyDeposit();
            try
            {
                var account1 = new BankAccount("TestName2", -55);
            }
            catch (ArgumentOutOfRangeException errorVariable1)
            {
                Console.WriteLine("\nInvalid object creation.", errorVariable1.ToString());
            }
        }
    }
    //to add new program files, right-click the namespace name in solution explorer > add > class
    //to view new program files, expand the namespace name in solution explorer and view the other files 
}
