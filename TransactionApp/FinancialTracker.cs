using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.MessageBox;

namespace TransactionApp
{
    static class FinancialTracker
    {
        private static SqlDataBase dataBase;
        static FinancialTracker()
        {
            dataBase = new SqlDataBase();
            dataBase.OpenConection();
        }

        public static void AddTransaction(Transaction transaction)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"INSERT INTO Transactions VALUES ({transaction.Amount}, '{transaction.Category}', '{transaction.Date}')";
            var command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            Show("Данные успешно добавлены");
        }
        public static decimal GetBalance()
        {
            string queryString = "SELECT SUM(amount) FROM Transactions";
            return GetInfo(queryString);
        }

        private static decimal GetInfo(string queryString)
        {
            var command = new SqlCommand(queryString, dataBase.GetConnection());
            var result = command.ExecuteScalar();

            result = result is DBNull ? 0 : result;

            return Convert.ToDecimal(result);
        }

        public static decimal GetExpensesByCategory(string category)
        {
            string queryString = $"SELECT SUM(amount) FROM Transactions WHERE category = '{category}'";
            return GetInfo(queryString);
        }

    }
}
