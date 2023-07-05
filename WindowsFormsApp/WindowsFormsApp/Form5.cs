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
        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString); // 创建一个数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con); // 创建Dataset和SQL server之间的桥接器，用于数据库操作
            DataSet ds = new DataSet();
            try
            {
                con.Open();  //打开连接
                sda.Fill(ds, "borrow_info"); //往窗体里readers表中填充数据集
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

        // 借书
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

        // 还书
        private void button2_Click(object sender, EventArgs e)
        {
            string rrno = txt_rrno.Text.Trim();
            string rbno = txt_rbno.Text.Trim();
            string sql = "update borrow_table set RTdate=GETDATE() where Rno='" + rrno + "' and Bno='" + rbno + "'";
            string sqlfine = "update borrow_table set BWfine=convert(int,(GETDATE()-BRlimit))*2 where Rno='" + rrno + "' and Bno='" + rbno + "' and GETDATE() > BRlimit";
            if (ExecuteSql(sqlfine) > 0)  // 逾期
            {
                DialogResult MsgBoxResult = MessageBox.Show("该书本未在规定时间内归还，请收取罚款 " + " 元！","提示",MessageBoxButtons.YesNo);
                if(MsgBoxResult == DialogResult.No)
                {
                    MessageBox.Show("还书失败，请缴纳罚款后还书！");
                    return;
                }
            }
            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("还书成功！");
                txt_rno.Clear();
                txt_bno.Clear();
                button4_Click(null,null);
                return;
            }
            else
            {
                MessageBox.Show("还书失败，请检查输入信息！");
                return;
            }
        }

        // 查询
        private void button4_Click(object sender, EventArgs e)
        {
            string rno = txt_rno.Text.Trim();
            string bno = txt_bno.Text.Trim();
            string updatesql = "update borrow_table set BWfine = CONVERT(int,(GETDATE()-BRdate))*2 where RTdate is NULL and GETDATE() > BRlimit";
            ExecuteSql(updatesql);         // 更新罚款记录
            string sql = "select Ino '信息编号', borrow_table.Rno '借书证号', borrow_table.Bno '书号', Rname '读者姓名', Bname '书名', BRdate '借出时间', BRlimit '限借日期', RTdate '还书日期', BWfine '罚款金额' from book_info,reader_info,borrow_table";
            sql = sql + " where borrow_table.Rno = reader_info.Rno and borrow_table.Bno = book_info.Bno";
            sql = sql + " and borrow_table.Rno like '%" + rno + "%' and borrow_table.Bno like '%" + bno + "%'";
            all_borrowed_info_table.DataSource = Query(sql).Tables["borrow_info"];
            int a = all_borrowed_info_table.CurrentRow.Index;  // 获取当前选中行
            string selected_rno = all_borrowed_info_table.Rows[a].Cells[1].Value.ToString().Trim();//获取该行的第0列数据
            string selected_bno = all_borrowed_info_table.Rows[a].Cells[2].Value.ToString().Trim();//获取该行的第0列数据
            txt_rrno.Text = selected_rno;
            txt_rbno.Text = selected_bno;
        }

        // 点击自动填充还书的书号和借书证号
        private void all_borrowed_info_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = all_borrowed_info_table.CurrentRow.Index;  // 获取当前选中行
            string selected_rno = all_borrowed_info_table.Rows[a].Cells[1].Value.ToString().Trim();//获取该行的第0列数据
            string selected_bno = all_borrowed_info_table.Rows[a].Cells[2].Value.ToString().Trim();//获取该行的第0列数据
            txt_rrno.Text = selected_rno;
            txt_rbno.Text = selected_bno;
        }

    }
}
