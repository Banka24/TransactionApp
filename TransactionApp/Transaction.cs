using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    class Transaction
    {
        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value >= 0 ? value : 0; }
        }

        public string Category { get; set; }
        public DateTime Date { get; set; }

        public Transaction(decimal amount, string category, DateTime date)
        {
            Amount = amount;
            Category = category;
            Date = date;
        }

    }
}
