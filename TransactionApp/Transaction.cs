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

        private string category;

        public string Category
        {
            get { return category; }
            set { category = string.IsNullOrEmpty(value) ? "NULL" : value; }
        }

        public DateTime Date { get; set; }

        public Transaction(decimal amount, string category, DateTime date)
        {
            Amount = amount;
            Category = category;
            Date = date;
        }

    }
}
