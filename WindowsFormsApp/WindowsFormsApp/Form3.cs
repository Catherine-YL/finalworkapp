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
    public partial class Form3 : Form
    {
        private static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public Form3()
        {
            InitializeComponent();
            string sql = "select Bno '书号', Bname '书名', Bpub '出版社', Bauthor '作者', Bborrow '是否可借', Bsumnum '馆藏总数', Bavailable '可借数量' from book_info";
            this.booklist.DataSource = Query(sql).Tables["books"];
        }

        // 查询数据
        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString); // 创建一个数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con); // 创建Dataset和SQL server之间的桥接器，用于数据库操作
            DataSet ds = new DataSet();  // 创一个数据集
            try
            {
                con.Open();  //打开连接
                sda.Fill(ds, "books"); //往窗体里students表中填充数据集
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message); //抛出异常
            }
            finally
            {
                sda.Dispose(); //sda处理，以便回收空间
                con.Close(); // 连接关闭
            }
        }

        //增删改数据
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

        //查询数据事件
        private void btn_find_Click(object sender, EventArgs e)
        {
            string bno = txt_bno.Text.Trim();
            string bname = txt_bname.Text.Trim();
            string bauthor = txt_bauthor.Text.Trim();
            string bpub = txt_bpub.Text.Trim();
            this.booklist.DataSource = Query("select Bno '书号', Bname '书名', Bpub '出版社', Bauthor '作者', Bborrow '是否可借', Bsumnum '馆藏总数', Bavailable '可借数量' from book_info where Bno like '%" + bno + "%' and Bname like '%" + bname + "%' and Bauthor like '%" + bauthor + "%' and Bpub like '%" + bpub + "%'").Tables["books"];
        }

        //删除数据事件
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int a = booklist.CurrentRow.Index;  // 获取当前选中行
            string bno = booklist.Rows[a].Cells[0].Value.ToString().Trim();//获取该行的第0列数据
            string sql = "delete from book_info where Bno='" + bno + "'";
            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功");
            }
        }

        // 添加窗体
        private void bnt_addForm7()
        {
            Form7 form7 = new Form7();
            form7.Owner = this;
            form7.Show();

        }
        // 修改窗体
        private void bnt_addForm8()
        {
            int a = booklist.CurrentRow.Index;  // 获取当前选中行
            string bno = booklist.Rows[a].Cells[0].Value.ToString().Trim();//获取该行的第0列数据
            Form8 form8 = new Form8(bno);
            form8.Owner = this;
            form8.Show();

        }
        // 查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
            btn_find_Click(sender, e);
        }
    
        // 添加书籍
        private void button2_Click(object sender, EventArgs e)
        {
            bnt_addForm7();
        }
        // 修改
        private void button3_Click(object sender, EventArgs e)
        {
            bnt_addForm8();
        }
        // 删除
        private void button4_Click(object sender, EventArgs e)
        {
            btn_delete_Click(sender, e);
        }

    }
}
