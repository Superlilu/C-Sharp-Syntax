using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using StdSys_WPF;

namespace StdSys_WPF
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Window
    {
        //public static string[] Kurse = new string[] { "Englisch", "Deutsch", "Chinesisch", "Japanisch", "Koreanisch", "Thailandisch"};
        //public int n = Kurse.Length;

        public int CreditPerCourse = 5;
                          
        public Page2(Student s, List<Courses> c)
        {
            InitializeComponent();
            tbx_name.Text = s.Name;
            tbx_classNo.Text = s.ClassNo.ToString();

            for (int i = 0; i < c.Count; i++ )
            {
                cbx_availableCourses.Items.Add(c[i]);
            }

            //for (int i = 0; i < n; i++)
            //{
            //    cbx_availableCourses.Items.Add(Kurse[i]);
            //}


            //if (cbx_availableCourses.SelectedItem.)


            //lbx_chosenCourses.Items.Add(Kurse[0]);
            //lbx_chosenCourses.Items.Add(Kurse[1]);
            //lbx_chosenCourses.Items.Add(Kurse[2]);
            //lbx_chosenCourses.Items.Add(Kurse[3]);
            //int x = lbx_chosenCourses.Items.Count;
            //int PointsPerCourse = 5;
            //tbx_credits.Text = (x * PointsPerCourse).ToString();

        }


        //public enum Kurse
        //{
        //    Englisch,
        //    Deutsch,
        //    Chinesisch,
        //    Japanisch,
        //    Koreanisch,
        //    Thailandisch
        //}

        private void btn_exit2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Count = cbx_availableCourses.Items.Count;
            if (Count != 0)
            {                
                object selected = cbx_availableCourses.SelectedItem;
                if (selected != null)
                {
                    cbx_availableCourses.Items.Remove(selected);
                    lbx_chosenCourses.Items.Add(selected);

                    int x = lbx_chosenCourses.Items.Count;
                    tbx_credits.Text = (x * CreditPerCourse).ToString();
                }
            }
        }

        private void ChosenCourse_selected(object sender, MouseButtonEventArgs e)
        {
            int Count = lbx_chosenCourses.Items.Count;
            if (Count != 0)
            {
                object chosenCourse_sel = lbx_chosenCourses.SelectedItem;
                lbx_chosenCourses.Items.Remove(chosenCourse_sel);
                cbx_availableCourses.Items.Add(chosenCourse_sel);

                int x = lbx_chosenCourses.Items.Count;
                tbx_credits.Text = (x * CreditPerCourse).ToString();
            }
        }
    }
}
