using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TransactionApp
{
    class FinancialTracker
    {
        public static void AddTransaction(Transaction transaction)
        {
            DataBase dataBase = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"INSERT INTO Transactions VALUES ({transaction.Amount}, '{transaction.Category}', '{transaction.Date}')";
            var command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
        public static decimal GetBalance()
        {
            DataBase dataBase = new DataBase();
            dataBase.OpenConection();
            string queryString = "SELECT SUM(amount) FROM Transactions";
            var command = new SqlCommand(queryString, dataBase.GetConnection());
            var result = command.ExecuteScalar();
            if(result is DBNull)
            {
                result = 0;
            }
            return Convert.ToDecimal(result);
        }

        public static decimal GetExpensesByCategory(string category)
        {
            DataBase dataBase = new DataBase();
            dataBase.OpenConection();
            string queryString = $"SELECT SUM(amount) FROM Transactions WHERE category = '{category}'";
            var command = new SqlCommand(queryString, dataBase.GetConnection());
            var result = command.ExecuteScalar();
            if (result is DBNull)
            {
                result = 0;
            }
            return Convert.ToDecimal(result);
        }

    }
}
