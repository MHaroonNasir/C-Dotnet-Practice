using System;
using System.Collections.Generic;
using System.Text;

namespace Beginner_Project_7
{
    public class Transaction
    {
        public decimal TransactionAmount { get; }
        public DateTime TransactionDate { get; }
        public string TransactionNotes { get; }

        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.TransactionAmount = amount;
            this.TransactionDate = date;
            this.TransactionNotes = notes;
        }
    }
    //to add new program files, right-click the namespace name in solution explorer > add > class
    //to view new program files, expand the namespace name in solution explorer and view the other files
}
