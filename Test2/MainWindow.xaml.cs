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

namespace Test2
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
            string message = "Möchten sie die Daten speichern?";
            MessageBoxResult result = MessageBox.Show(message,
                                                        "Meine Anwendung",
                                                        MessageBoxButton.YesNoCancel,
                                                        MessageBoxImage.Question,
                                                        MessageBoxResult.Yes);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("you pressed Yes",
                                "Meine Anwendung",
                                MessageBoxButton.OK,
                                MessageBoxImage.Hand,
                                MessageBoxResult.OK);
            }
            //int result = Convert.ToInt32(tbox1.Text) + Convert.ToInt32(tbox2.Text);
            //MessageBox.Show("sum is: " + result.ToString());
        }
    }
}
