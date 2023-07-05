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
    public partial class Form4 : Form
    {
        private static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public Form4()
        {
            InitializeComponent();
            string sql = "select Rno '借书证号',Rname '姓名',Rsex '性别',Rprofess '职称',Ravailable '可借数量',Rborrowed '已借数量',Rdpartmt '工作部门',Rtel '联系电话',login_id '账号名' from reader_info"; 
            this.readers_table.DataSource = Queryreaders(sql).Tables["readers"];
        }
        public static DataSet Queryreaders(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString); // 创建一个数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con); // 创建Dataset和SQL server之间的桥接器，用于数据库操作
            DataSet ds = new DataSet();
            try
            {
                con.Open();  //打开连接
                sda.Fill(ds, "readers"); //往窗体里readers表中填充数据集
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

        public static DataSet Querylist(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString); // 创建一个数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con); // 创建Dataset和SQL server之间的桥接器，用于数据库操作
            DataSet ds = new DataSet();
            try
            {
                con.Open();  //打开连接
                sda.Fill(ds, "borrowlist"); //往窗体里borrowlists表中填充数据集
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

        private void bnt_find_Click(object sender, EventArgs e)
        {
            string rno = txt_rno.Text.Trim();
            string rname = txt_rname.Text.Trim();
            string sql = "select Rno '借书证号',Rname '姓名',Rsex '性别',Rprofess '职称',Ravailable '可借数量',Rborrowed '已借数量',Rdpartmt '工作部门',Rtel '联系电话',login_id '账号名' from reader_info";
            sql = sql + " where Rno like '%" + rno + "%' and Rname like '%" + rname + "%'";
            this.readers_table.DataSource = Queryreaders(sql).Tables["readers"];
        }

        private void readers_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = readers_table.CurrentRow.Index;  // 获取当前选中行
            string rno = readers_table.Rows[a].Cells[0].Value.ToString().Trim();//获取该行的第0列数据
            string sql = "select borrow_table.Bno '书号', Bname '书名', BRdate '借出日期', BRlimit '限借日期', BWfine '罚款金额' from borrow_table,book_info,reader_info";
            sql = sql + " where reader_info.Rno = borrow_table.Rno and book_info.Bno = borrow_table.Bno and borrow_table.RTdate is NULL and borrow_table.Rno = '" + rno + "'";
            this.borrow_info.DataSource = Querylist(sql).Tables["borrowlist"];
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int a = readers_table.CurrentRow.Index;  // 获取当前选中行
            string rno = readers_table.Rows[a].Cells[0].Value.ToString().Trim();//获取该行的第0列数据
            string sql = "delete from reader_info where Rno='" + rno + "'";
            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功");
            }
        }

        // 添加窗体
        private void bnt_addForm9()
        {
            Form9 form9 = new Form9();
            form9.Owner = this;
            form9.Show();
        }

        // 修改窗体
        private void bnt_addForm10()
        {
            int a = readers_table.CurrentRow.Index;  // 获取当前选中行
            string rno = readers_table.Rows[a].Cells[0].Value.ToString().Trim();//获取该行的第0列数据
            Form10 form10 = new Form10(rno);
            form10.Owner = this;
            form10.Show();
        }

        // 查询
        private void button1_Click(object sender, EventArgs e)
        {
            bnt_find_Click(sender, e);
        }

        // 添加
        private void button2_Click(object sender, EventArgs e)
        {
            bnt_addForm9();
        }

        // 修改
        private void button3_Click(object sender, EventArgs e)
        {
            bnt_addForm10();
        }

        // 删除
        private void button4_Click(object sender, EventArgs e)
        {
            btn_delete_Click(sender, e);
        }
    }
}
