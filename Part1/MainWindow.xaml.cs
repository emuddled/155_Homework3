/// Homework No. 3		Exercise Part 1
/// File Name: MorgageIntrestCalc
/// @author: Evan Sinclair
/// Date:  Sept 18, 2020
///
/// Problem Statement: Write a GUI program that reads in the amount of a monthly mortgage payment and the 
/// outstanding balance (i.e., the amount still owed) and then outputs the amount of the payment that goes
/// to interest and the amount that goes to principal (i.e., the amount that goes to reducing the debt). 
/// Assume that the annual interest payment is 6.39 percent. 
/// 
/// Overall Plan:
/// 1)Create text fields for outstanding balance and morgage payment
/// 2)Create Button for execution
/// 3)Calculate the ammount going to intrest payments using 6.39% and divide by 12 for one month payment
/// 4)subtract intrest paid from total payment to find principal payed
/// 5)display the results in MessageBox
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Part1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            
            
            const double intrest = .0639;
            // read in and convert to double
            double outstandingBalance = Convert.ToDouble(OBalance.Text);
            double morgagePayment = Convert.ToDouble(MPayment.Text);

            // calculate intrest paid and principal paid 
            
            double intrestPaid = (outstandingBalance * intrest) / 12;
            double principalPaid = morgagePayment - intrestPaid;

            // display information
            MessageBox.Show("You paid " + String.Format("{0:0.00}", intrestPaid) + " of intrest and "
                + String.Format("{0:0.00}", principalPaid) + " of principal");
        }
    }
}
