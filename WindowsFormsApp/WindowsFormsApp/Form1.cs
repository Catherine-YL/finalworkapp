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
        public int identity;
        public string pro = "server=localhost;database=Liberary;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login_id = txt_id.Text.Trim();
            string pwd = txt_pwd.Text.Trim();
            string connectionString = pro + "uid=" + login_id + ";pwd=" + pwd + ";";
            login(connectionString);
        }
        public static int login()
        {
            SqlConnection con = new SqlConnection(connectionString);//创建一个数据库连接
            SqlCommand cmd = new SqlCommand(sql, con);//创建一个SqlCommand，用于对数据库进行操作try
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery(); // rows接受sql执行后返回的行数
                return rows;
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
