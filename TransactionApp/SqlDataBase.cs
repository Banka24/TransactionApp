using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.MessageBox;

namespace TransactionApp
{
    class SqlDataBase
    {
        private string DataSource = ConfigurationManager.AppSettings.Get("DataSource");
        private string InitialCatalog = ConfigurationManager.AppSettings.Get("InitialCatalog");
        private string InregratedSecurity = ConfigurationManager.AppSettings.Get("IntegratedSecurity");
        private SqlConnection sqlConnection;

        public SqlDataBase()
        {
            try
            {
                sqlConnection = new SqlConnection($@"Data Source={DataSource};Initial Catalog={InitialCatalog};Integrated Security={InregratedSecurity}");
            }
            catch (SqlException)
            {
                Show("ошибка доступа к базе данных или ошибка подключения к базе данных");
            }
            
        }

        public void OpenConection()
        {
            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
