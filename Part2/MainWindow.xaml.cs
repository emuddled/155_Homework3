/// Homework No. 3		Exercise Part 2
/// File Name: VendingChange
/// @author: Evan Sinclair
/// Date:  Sept 18, 2020
///
/// Problem Statement: Write a program (Console or GUI) that determines the change to be dispensed from a vending machine. 
/// An item in the machine can cost between 25 cents and 1 dollar, in 5-cent increments (25, 30, 35,…,95, 100), and the 
/// machine accepts only a single dollar bill to pay for the item.
/// 
/// Overall Plan:
/// 1)Create text fields for cost of item to be input
/// 2)Create Button for execution
/// 3)Use division and modulo operator to compute how many of each coin to return
/// 4)Display change in MessageBox
///
///

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

namespace Part2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // read in text box and convert to int
            int changeTotal = 100 - Convert.ToInt32(Cost.Text);
            
            // calculate number of coins to return
            int quarters, dimes, nickels;
            quarters = changeTotal / 25;
            dimes = (changeTotal % 25) / 10;
            nickels = ((changeTotal % 25) % 10) / 5;

            // display the data
            MessageBox.Show("The change you recieve is:\n" + quarters + " Quarters\n" + dimes + " Dimes\n" + nickels + " nickels");
        }
    }
}
