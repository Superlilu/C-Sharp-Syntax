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
        //public void TestUser()
        //{
        //    User[] TestUsers = new User[2];
        //    TestUsers[0] = new User("Lily", "1617");
        //    TestUsers[1] = new User("Peiren", "1217");
        //}

    }
    public class Student : User
    {
        [XmlElement("Name")]
        public string Name;
        [XmlElement("ClassNo")]
        public string ClassNo;
        [XmlArray("SelectedCourses")]
        [XmlArrayItem("SelectedCourse")]
        public Courses[] SelCourses;

        public Student(string name, string pw) : base(name, pw)
        {
            this.Name = name;
            this.Pw = pw;
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
        [XmlElement("Teacher")]
        public string Teacher;
        [XmlArray("StudentArr")]
        [XmlArrayItem("Student")]
        public Student[] Students;
        [XmlElement("Credit")]
        public int Credit;

        public Courses(string teacher, int credit)
        {
            this.Teacher = teacher;
            this.Credit = credit;
        }
    }

    public class TestLog
    {
        public TestLog()
        {

        }
        public bool TestIfLog()
        {
            Console.WriteLine("please input your Username: ");
            string testName = Console.ReadLine();
            Console.WriteLine("please input your Password: ");
            string testPw = Console.ReadLine();

            User[] TestUsers = new User[2];
            TestUsers[0] = new User("Lily", "1617");
            TestUsers[1] = new User("Peiren", "1217");

            if (Array.Exists(TestUsers, Item => Item.Username == testName && Item.Pw == testPw))
            {
                Console.WriteLine("seccessfully logged in!");
                return true;
            }
            else
            {
                Console.WriteLine("failed to log in. Please try another Username or Password.\n");
                return false;
            }

        }
    }
    public partial class MainWindow : Window
    {
        private User[] TestUsers;
        public MainWindow()
        {
            
            InitializeComponent();

            TestUsers = new User[2];
            TestUsers[0] = new User("Lily", "1617");
            TestUsers[1] = new User("Peiren", "1217");

            //UserList List = new UserList("UserSystem");
            //List.Listtype = "UserSystem";
            //User[] TestUsers = new User[2];
            //TestUsers[0] = new User("Lily", "1617");
            //TestUsers[1] = new User("Peiren", "1217");
            //List.Users = TestUsers;

            //XmlSerializer serializer = new XmlSerializer(typeof(UserList));
            //FileStream fs = new FileStream("StdSys.xml", FileMode.Create);
            //serializer.Serialize(fs, List);
            //fs.Close();

            //TestLog tl = new TestLog();
            //while (tl.TestIfLog() == false)
            //{
            //}

            //FileStream fs2 = new FileStream("StdSys.xml", FileMode.Open);
            //UserList newUsers = (UserList)serializer.Deserialize(fs2);
            //serializer.Serialize(Console.Out, newUsers);
            //Console.ReadLine();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("do you really want to exit?", "Wow", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (MessageBoxResult.Yes == x)
            {
                Application.Current.Shutdown();

            }
            
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            //if ((User_name1.Text == TestUsers[0].Username && PasswordBox.Password == TestUsers[0].Pw) || (User_name1.Text == TestUsers[1].Username && PasswordBox.Password == TestUsers[1].Pw))
            if ((User_name1.Text == TestUsers[0].Username && PasswordBox.Password == TestUsers[0].Pw) || (User_name1.Text == TestUsers[1].Username && PasswordBox.Password == TestUsers[1].Pw))
            {
                MessageBox.Show("succsessfully logged in", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("wrong Username or Password!", "Result", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }
    }
}
