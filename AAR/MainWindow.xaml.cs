using System;
using System.Windows;
using System.Windows.Controls;

namespace AAR
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(); // Set ViewModel as DataContext
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // Add your login logic here
            MessageBox.Show("Login button clicked!");
        }
    }
}
