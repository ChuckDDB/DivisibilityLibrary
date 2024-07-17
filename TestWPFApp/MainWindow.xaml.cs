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
using DivisibilityLibrary;

namespace TestWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int maxNumber))
            {
                NumberChecker checker = new NumberChecker();
                string[] results = checker.CheckNumbers(maxNumber);

                ResultsListBox.Items.Clear();
                foreach (string result in results)
                {
                    ResultsListBox.Items.Add(result);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Error");
            }
        }
    }
}
