using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_7
{
    public class BankAccount //notice that the 'public' keyword has been added to this line, this class has 3 five members
    { //this class are examples of abstraction as it hides unnecessary details from consumer
        //this and the 'transaction' class are examples of encapsulation, grouping related propertirs, methods and other members intop a single unit/object
        private static int accountNumberSeed = 1000000000; //'private' means it can only be accessed internally, 'static' means it is shared by all 'BankAccount' objects
                                                    //non-static variables are unique each instance of this classes' object, therefore the 3 bottom properties are non-static
        public string AccountNumber { get; } //these members are 'properties', notice how the property name starts with uppercase
        public string Owner { get; set; } //get returns the value of a variable, the set method assigns a value
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.TransactionAmount;
                    Console.WriteLine("Calling get functionality of 'Balance' property###");
                }
                return balance;
            }
        }

        //private readonly decimal minimumBalance; //the 'readonly' keyword makes it this property value cannot be changed once it is initialised within the constructor
        //this member should be mentioned again in the constructor and from there its value will not change

        private List<Transaction> allTransactions = new List<Transaction>(); //here any empty list of transactions are being created

        //public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }
        //above is an example of constructor chaining using the 'this' keyword

        /*protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {

        }*/
        //above is an example of a 'protected' method, this keyword makes the method only accesible for derived classes, the 'virtual' keyword allows for polymorphism
        //notice that the method name has a ? in front of it, the ? annotation tells thet this method could return a null value, otherwise it will need to be labelled as 'void' (not sure about the void part)

        public BankAccount(string name, decimal initialBalance) //this is a constructor method, it is noticable as it has the same name as the class
        {                                   //constructors are used to initialse an object of a particular class type, defining constructor assigns values when creating new object                                           
            this.Owner = name; //the name mentioned after 'this' is the same as that defined in the properties of the class written above, these names cannot be different
            //the values given to these fields are the same as specified in the arguements of this constructor method
            //the above 2 lines are assigning the arguements passed into the constructor from object creation to the properties of the class
            //this. is optional, it can also be written as Balance = initialBalance, it is a stylistic choice
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.AccountNumber = accountNumberSeed.ToString();
            accountNumberSeed++;
            //the above 2 lines make it so that each new object instance of this class will have a unique account number, also becuase 'accountNumberSeed, is private and static
        }

        public void MakeDeposit(decimal amount, DateTime date, string note) //these members are methods, notice how the method name starts with uppercase
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Deposit must exceed 0.");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
            
            //prins statements to show the contents and methods of the list, the list contains objects whose methods can be called
            Console.WriteLine($"\nTransaction list after deposit:  {allTransactions}");
            foreach (var item in allTransactions)
            {
                Console.WriteLine($"{item} {item.TransactionAmount} {item.TransactionDate} {item.TransactionNotes}");
            }
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrawal must exceed 0.");
            }
            if (this.Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal.");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

            //prins statements to show the contents and methods of the list, the list contains objects whose methods can be called
            Console.WriteLine($"\nTransaction list after withdrawal:  {allTransactions}");
            foreach (var item in allTransactions)
            {
                Console.WriteLine($"{item} {item.TransactionAmount} {item.TransactionDate} {item.TransactionNotes}");
            }
        }

        public virtual void PerformMonthEndTransaction() //this method is where the concept of polymorphism is to be implmented
        { //the 'virtual' keyword allows any derived class to change/ovveride the implementation/behaviour of this method
            //methods can also be declared with keyword 'abstract' which forced derived class to override the behaviour, in which case the base class does not provide implementation for abstract method
        }
    }
    //to add new program files, right-click the namespace name in solution explorer > add > class
    //to view new program files, expand the namespace name in solution explorer and view the other files 
}
