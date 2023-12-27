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
            decimal amount = 0;
            foreach(Transaction transaction in Storage.allTransactions)
            {
                amount += transaction.Amount;
            }
            
            return Convert.ToString(amount);
        }

        public static string GetExpensesByCategory(string category)
        {
            decimal amount = 0;

            foreach(Transaction transaction in Storage.allTransactions)
            {
                if(transaction.Category == category)
                {
                    amount += transaction.Amount;
                }
            }

            return Convert.ToString(amount);
        }
    }
}
