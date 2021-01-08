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
using System.Xml.Serialization;
using System.IO;

namespace StdSys_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [XmlRoot("UserList")]
    public class UserList
    {
        [XmlElement("Listtype")]
        public string Listtype;
        [XmlArray("UserArray")]
        [XmlArrayItem("User")]
        public User[] Users;

        public UserList() { }
        public UserList(string type)
        {
            this.Listtype = type;
        }

    }
    public class User
    {
        [XmlElement("Username")]
        public string Username;
        [XmlElement("Password")]
        public string Pw;

        public User() { }
        public User(string username, string pw)
        {
            this.Username = username;
            this.Pw = pw;
        }

    }
    public class Student : User
    {
        [XmlElement("Name")]
        public string Name;
        [XmlElement("ClassNo")]
        public int ClassNo;
        [XmlArray("SelectedCourses")]
        [XmlArrayItem("SelectedCourse")]
        public Courses[] CoursesPerStudent;

        public Student(string name, string pw) : base(name, pw)
        {
            this.Name = name;
            this.Pw = pw;
            this.ClassNo = 5;
        }
        public Courses[] AddCourse(Courses c)
        {
            CoursesPerStudent = new Courses[] { };
            CoursesPerStudent.Append(c);
            CoursesPerStudent.OrderBy(c => c.Course);
            return CoursesPerStudent;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Teacher : User
    {
        [XmlElement("Name")]
        public string Name;
        [XmlArray("CoursesToTeach")]
        [XmlArrayItem("CourseToTeach")]
        public Courses[] CoursesTT;

        public Teacher(string name, string pw) : base(name, pw)
        {
            this.Name = name;
            this.Pw = pw;
        }
    }
    public class Courses
    {
        [XmlElement("Course")]
        public string Course;
        [XmlElement("Teacher")]
        public string Teacher;
        [XmlArray("StudentArr")]
        [XmlArrayItem("Student")]
        public Student[] StudentInCourse;
        [XmlElement("CourseCredit")]
        public int CourseCredit;

        public Courses(string course, string teacher, int credit)
        {
            this.Course = course;
            this.Teacher = teacher;
            this.CourseCredit = credit;
        }
        public Courses()
        {
            this.Course = "";
            this.Teacher = "";
            this.CourseCredit = 0;
        }
        public Student[] AddStudent(Student s)
        {
            StudentInCourse = new Student[] { };
            StudentInCourse.Append(s);
            StudentInCourse.OrderBy(s => s.Name);
            return StudentInCourse;
        }

        public override string ToString()
        {
            return Course;
        }
    }
    public partial class MainWindow : Window
    {
        //Courses[] allCourses = new Courses[6];
        List<Courses> allCourses = new List<Courses>();
        List<Student> Studenten = new List<Student>();
        public MainWindow()
        {
            
            InitializeComponent();

            Studenten.Add(new Student("Lily", "1617"));
            Studenten.Add(new Student("Peiren", "1217"));

            allCourses.Add(new Courses("Chemie", "Oli", 5));
            allCourses.Add(new Courses("Mathe", "Jan", 5));
            allCourses.Add(new Courses("Physik", "Lisa", 5));
            allCourses.Add(new Courses("Mechanik", "Peter", 5));
            allCourses.Add(new Courses("Robotik", "Roos", 5));
            allCourses.Add(new Courses("Produktion", "Roos", 5));

            //Courses c1 = new Courses("Chemie", "Oli", 5);
            //Courses c2 = new Courses("Mathe", "Jan", 5);
            //Courses c3 = new Courses("Physik", "Lisa", 5);
            //Courses c4 = new Courses("Mechanik", "Peter", 5);
            //Courses c5 = new Courses("Robotik", "Roos", 5);
            //Courses c6 = new Courses("Produktion", "Roos", 5);
            //allCourses.Append(c1);
            //allCourses.Append(c2);
            //allCourses.Append(c3);
            //allCourses.Append(c4);
            //allCourses.Append(c5);
            //allCourses.Append(c6);
            allCourses.OrderBy(c1 => c1.Course);

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("do you really want to exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (MessageBoxResult.Yes == x)
            {
                Application.Current.Shutdown();

            }
            
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {   
            int x = Studenten.FindIndex((Item => Item.Name == User_name1.Text && Item.Pw == PasswordBox.Password));
            if (x != -1)
            {
                MessageBox.Show("succsessfully logged in", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
                Page2 p2 = new Page2(Studenten[x], allCourses);
                this.Hide();
                p2.Show();

                //for (int i = 0; i < allCourses.Length; i++)
                //{
                //    cbx_availableCourses.Items.Add(allCourses[i]);
                //}
            }
            else
            {
                MessageBox.Show("wrong Username or Password!", "Result", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
