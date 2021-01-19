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
using System.Data.SqlClient;
using System.Data;

namespace ADONET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Connect()
        {
            string connStr2 = @"Data source=DESKTOP-L99NRH0\SQLEXPRESS;Initial Catalog=test;User ID=sa;Password=pwdpwd";
            SqlConnection conn = null;

            conn = new SqlConnection(connStr2);
            conn.Open();
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void clickEvent(object sender, RoutedEventArgs e)
        //{
        //    string connStr = @"Data source=DESKTOP-L99NRH0\SQLEXPRESS;Initial Catalog=test;User ID=sa;Password=pwdpwd";
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connStr))
        //        {
        //            conn.Open();
        //            MessageBox.Show("Verbindung zu Database succsessful");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Verbindung failed! " + ex.Message);
        //    }
        //    //finally 
        //    //{
        //    //    if(conn != null)
        //    //    {
        //    //        conn.Close();
        //    //    }
        //    //}
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connStr2 = @"Data source=DESKTOP-L99NRH0\SQLEXPRESS;Initial Catalog=test;User ID=sa;Password=pwdpwd";
            SqlConnection conn = null;



            //string sql2 = @"CREATE table userinfo2 
            //                (   id int identity(1, 1) primary key,
            //                    name varchar(20),
            //                    password varchar(20)
            //                )";

            //// Register:
            //try
            //{
            //    conn = new SqlConnection(connStr2);
            //    conn.Open();

            //    string sql = "insert into userinfo(name,password) values('{0}','{1}')";
            //    sql = string.Format(sql, textBox1.Text, textBox2.Text);

            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    int returnvalue = cmd.ExecuteNonQuery();

            //    if (returnvalue != -1)
            //    {
            //        MessageBox.Show("register succsessful！");
            //    }
            //}

            // Check if Username unique
            try
            {
                conn = new SqlConnection(connStr2);
                conn.Open();

                string checkNameSql = "select count(*) from userinfo where name='{0}'";
                checkNameSql = string.Format(checkNameSql, textBox1.Text);
                SqlCommand cmdCheckName = new SqlCommand(checkNameSql, conn);

                int isRepeatName = (int)cmdCheckName.ExecuteScalar();
                if (isRepeatName != 0)
                {
                    MessageBox.Show("Username already exsists！");
                    return;
                }

                string sql = "insert into userinfo(name,password) values('{0}','{1}')";
                sql = string.Format(sql, textBox1.Text, textBox2.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);

                int returnvalue = cmd.ExecuteNonQuery();
                if (returnvalue != -1)
                {
                    MessageBox.Show("Register sucsessfull！");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("register failed" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            string connStr3 = @"Data source=DESKTOP-L99NRH0\SQLEXPRESS;Initial Catalog=test;User ID=sa;Password=pwdpwd";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr3);
                conn.Open();

                string sql = "Select count(*) from userinfo where name='{0}' and password='{1}'";
                sql = string.Format(sql, textBox1.Text, textBox2.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);

                int returnvalue = (int)cmd.ExecuteScalar();
                if (returnvalue != 0)
                {
                    MessageBox.Show("Log in succsessful！");
                }
                else
                {
                    MessageBox.Show("LogIn failed！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to log in！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Register2_Click(object sender, RoutedEventArgs e)
        {
            string connStr3 = @"Data source=DESKTOP-L99NRH0\SQLEXPRESS;Initial Catalog=test;User ID=sa;Password=pwdpwd";
            SqlConnection conn = null;
            //string AddUser = @"create procedure AddUser 
            //                ((@name varchar(20), @password varchar(20)) 
            //                as 
            //                begin 
            //                insert into userinfo(name, password) values(@name, @password) 
            //                end)";
            //Connect();
            try
            {
                conn = new SqlConnection(connStr3);
                conn.Open();

                SqlCommand cmd = new SqlCommand("AddUser", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", textBox1.Text);
                cmd.Parameters.AddWithValue("password", textBox2.Text);

                int returnvalue = cmd.ExecuteNonQuery();
                Console.WriteLine(returnvalue);
                if (returnvalue != -1)
                {
                    MessageBox.Show("regi succsessful！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Regi failed！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }


                //create procedure AddUser(@name varchar(20), @password varchar(20))
                //as
                //begin
                //insert into userinfo(name, password) values(@name, @password);
                //end

            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string connStr = @"Data source=DESKTOP-L99NRH0\SQLEXPRESS;Initial Catalog=test;User ID=sa;Password=pwdpwd";
            SqlConnection conn = null;
            SqlDataReader dr = null;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                string sql = "select id,password from userinfo where name='{0}'";
                sql = string.Format(sql, textBox1.Text);

                SqlCommand cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string msg = "id：" + dr[0] + " Pwd：" + dr[1];
                    label2.Content = msg;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("search failed！" + ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
