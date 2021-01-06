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

namespace Ub_Youtube
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
            //btn_hello.Content = "Hallo Welt";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //btn_kuka.Content = "Willkommen";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //string message = "Hallo " + txtBox_Vorname.Text + " " + txtBox_Nachname.Text;
            //lbl_message.Content = message;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //if(rb_bronze.IsChecked == true)
            //{
            //    lbl_abo.Content = "bronze gewählt";
            //}
            //else if(rb_silber.IsChecked == true)
            //{
            //    lbl_abo.Content = "silber gewählt";
            //}
            //else if (rb_gold.IsChecked == true)
            //{
            //    lbl_abo.Content = "gold gewählt";
            //}

            //if(rb_mann.IsChecked == true)
            //{
            //    lbl_geschlecht.Content = "Du bist mann";
            //}
            //if(rb_frau.IsChecked == true)
            //{
            //    lbl_geschlecht.Content = "Du bist frau";
            //}
        }

        //private void CheckBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    btn_register.IsEnabled = true;
        //}

        //private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    btn_register.IsEnabled = false;
        //}
    }
}
