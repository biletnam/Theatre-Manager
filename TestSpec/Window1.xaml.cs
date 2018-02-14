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
using System.Windows.Shapes;

namespace TestSpec
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string [] ShowDetails = new string[3];
        List<string[]> ShowList = new List<string[]>();
        int SeatsLeft = 700;
        public Window1()
        {
            InitializeComponent();
        }
        private void AddName(object sender, RoutedEventArgs e)
        {
            ShowDetails[0] = ShowName.Text;
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowDetails[1] = SetDate.Text;
        }

        private void AddPrice(object sender, RoutedEventArgs e)
        {
            ShowDetails[2] = Price.Text;
        }

        private void ConfirmShow(object sender, RoutedEventArgs e)
        {
            ShowList.Add(ShowDetails);
        }
    }
}