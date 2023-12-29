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
        public static string GetBalance()
        {
            return Storage.allTransactions.Sum(transaction => transaction.Amount).ToString();
        }

        public static string GetExpensesByCategory(string category)
        {
            return Storage.allTransactions.Where(transaction => transaction.Category == category).Sum(transaction => transaction.Amount).ToString();
        }
    }
}
