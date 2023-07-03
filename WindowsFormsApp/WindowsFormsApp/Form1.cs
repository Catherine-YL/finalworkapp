using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public static int identity;    // 1为admin 0为reader
        public static string login_id, pwd;
        public static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_id = txt_id.Text.Trim();
            pwd = txt_pwd.Text.Trim();
            login();
        }
        public int login()
        {
            SqlConnection con = new SqlConnection(connectionString);//创建一个数据库连接
            string sql = "select identy from login_table where login_id='" + login_id + "' and passwd='" + pwd + "'";
            Console.WriteLine(sql);
            SqlCommand cmd = new SqlCommand(sql, con);//创建一个SqlCommand，用于对数据库进行操作try
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string identity_str = dr[0].ToString();
                    if (identity_str == "admin")
                    {
                        identity = 1;
                        MessageBox.Show("登录成功！");
                        Form2 form2 = new Form2();
                        form2.Owner = this;
                        form2.Show();
                        this.Hide();
                        return 1;
                    }
                    else if (identity_str == "reader")
                    {
                        identity = 0;
                        MessageBox.Show("登录成功！");
                        Form6 form6 = new Form6();
                        form6.Owner = this;
                        form6.Show();
                        this.Hide();
                        return 0;
                    }
                    else
                    {
                        MessageBox.Show("权限错误，请联系管理员！");
                        return -1;   // 权限错误
                    }
                }
                else
                {
                    MessageBox.Show("登录失败，请检查用户名和密码！");
                    return -2;    // 无用户或密码错误、用户名错误
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose(); // 对Sq1Command进行处理，回收
                con.Close(); // 连接关闭
            }
        }
    }
}
