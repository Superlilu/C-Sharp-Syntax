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

namespace StdSys_WPF
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Window
    {
        public Page3(List<Teacher> teachers, List<Courses> allCourses, List<Student> Studenten, int x)
        {
            InitializeComponent();
            teachers.Sort();

            foreach (Teacher c in teachers)
            {
                cbx_TeacherList.Items.Add(c);
            }
            for (int i = 0; i < teachers.Count; i++)
            {
                for (int j = 0; j < allCourses.Count; j++)
                {
                    if (allCourses[j].Teacher.TeacherName == teachers[i].TeacherName)
                    {
                        teachers[i].CoursesPerTeacher.Add(allCourses[j]);
                    }
                }
            }

            foreach (Courses c in allCourses)
            {
                cbx_CourseList.Items.Add(c);
            }

            foreach (Courses c in cbx_CourseList.Items)
            {
                if (c.StdPerCourses.Contains(Studenten[x]))
                {
                    lbx_StdInCourse.Items.Add(Studenten[x]);
                }
            }
        }

        private void cbx_TeacherList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selected_orig = cbx_TeacherList.SelectedItem;
            Teacher selected = (Teacher)selected_orig;
            lbx_CoursesPerTeacher.Items.Clear();
            for (int i = 0; i < selected.CoursesPerTeacher.Count; i++)
            {
                lbx_CoursesPerTeacher.Items.Add(selected.CoursesPerTeacher[i]);
            }
        }

        private void cbx_CourseList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbx_StdInCourse.Items.Clear();
            object selected_ori = cbx_CourseList.SelectedItem;
            Courses selected = (Courses)selected_ori;

            foreach (Student std in selected.StdPerCourses)
            {
                lbx_StdInCourse.Items.Add(std);
            }
        }
    }
}
