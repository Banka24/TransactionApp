using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TransactionApp
{
    /// <summary>
    /// Логика взаимодействия для AddTransaction.xaml
    /// </summary>
    public partial class AddTransaction : Page
    {
        public AddTransaction()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!decimal.TryParse(AddNumber.Text, out decimal amount))
            {
                MessageBox.Show("Введите сумму числом");
            }

            DateTime date = Convert.ToDateTime(DateTransaction.SelectedDate);
            string category = Category.Text;

            Transaction newTransaction = new Transaction(amount, category, date);

            FinancialTracker.AddTransaction(newTransaction);
        }
    }
}
