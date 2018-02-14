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


namespace TestSpec
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

        private void btnConfirmPlay_Click(object sender, RoutedEventArgs e)
        {
            DateTime? start = StartDate.SelectedDate;
            DateTime? end = StartDate.SelectedDate;
            if (Theatre.AddPlay(p_PlayName:NameTextBox.Text,
                p_StartDate:start.Value, 
                p_EndDate:end.Value, 
                p_UpperCirclePrice:UpperCircleTextBox.Text, 
                p_DressCirclePrice:DressCircleTextBox.Text, 
                p_StallPrice:StallTextBox.Text))
            {
                MessageBox.Show("Successfully added play.");
            }
        }

        private void btnDeletePlay_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
