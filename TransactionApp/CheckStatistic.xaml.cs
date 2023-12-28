﻿using System;
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
    /// Логика взаимодействия для CheckStatistic.xaml
    /// </summary>
    public partial class CheckStatistic : Page
    {
        public CheckStatistic()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string category = Category.Text;
            decimal amount = FinancialTracker.GetExpensesByCategory(category);
            rasxodi.Text = amount.ToString();
        }
    }
}
