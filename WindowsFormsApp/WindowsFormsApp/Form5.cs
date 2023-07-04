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
    public partial class Form5 : Form
    {
        private static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Form5()
        {
            InitializeComponent();
        }

        public static int ExecuteSql(String sql)
        {
            Console.WriteLine(sql);
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


        private void button1_Click(object sender, EventArgs e)
        {
            string brno = txt_brno.Text.Trim();
            string bbno = txt_bbno.Text.Trim();
            string sql = "insert into borrow_table values('" + brno + "','" + bbno + "',GETDATE()-3, GETDATE()+30, NULL, 0)";
            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("登记成功！");
            }
            else
            {
                MessageBox.Show("登记失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rrno = txt_rrno.Text.Trim();
            string rbno = txt_rbno.Text.Trim();
            string sql = "update borrow_table set RTdate=GETDATE() where Rno='" + rrno + "' and Bno='" + rbno + "'";
            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("还书成功！");
            }
            else
            {
                MessageBox.Show("还书失败！");
            }
        }
    }
}
