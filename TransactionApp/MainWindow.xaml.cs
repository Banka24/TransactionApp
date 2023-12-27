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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Спасибо за использования финансового трекера!");
            Environment.Exit(0);
        }

        private void StaticCheckBtn(object sender, RoutedEventArgs e)
        {
            NavigatPages.Navigate(new CheckStatistic());
        }

        private void CheckBalancBtn(object sender, RoutedEventArgs e)
        {
            NavigatPages.Navigate(new CheckBalance());
        }

        private void AddTransactionsBtn(object sender, RoutedEventArgs e)
        {
            NavigatPages.Navigate(new AddTransaction());
        }
    }
}
