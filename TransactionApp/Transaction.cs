using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    class Transaction
    {
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

        public Transaction(decimal amount, string category, DateTime date)
        {
            Amount = amount;
            Category = category;
            Date = date;
        }

        public Transaction()
        {

        }

    }
}
