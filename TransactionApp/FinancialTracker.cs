using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    class FinancialTracker
    {
        public static void AddTransaction(Transaction transaction)
        {
            Storage.allTransactions.Add(transaction);
        }
        public static decimal GetBalance()
        {
            decimal amount = Storage.allTransactions.Sum(transaction => transaction.Amount);
            
            return amount;
        }

        public static decimal GetExpensesByCategory(string category)
        {
            decimal amount = Storage.allTransactions.Where(transaction => transaction.Category == category).Sum(transaction => transaction.Amount);

            return amount;
        }
    }
}
