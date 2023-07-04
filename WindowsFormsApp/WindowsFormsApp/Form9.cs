using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btn_confirm_add_Click(object sender, EventArgs e)
        {
            string rno = txt_rno.Text.Trim(); //获取Form2中文本框txt_add_sid的值，并去除结尾的空字符
            string rname = txt_rname.Text.Trim();
            string rsex = txt_rsex.Text.Trim();
            string rprofess = txt_rprofess.Text.Trim();
            string rdpartmt = txt_rdpartmt.Text.Trim();
            string rtel = txt_rtel.Text.Trim();
            string ravailable = txt_ravailable.Text.Trim();
            string rborrowed = txt_rborrowed.Text.Trim();
            string login_id = rno;
            string sql = "insert into reader_info values('" + rno + "','" + rname + "','" + rsex + "','" + rprofess + "'," + ravailable + "," + rborrowed + ",'" + rdpartmt + "','" + rtel + "','" + login_id + "')";
            if (Form4.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败，请重试！");
            }
            this.Close();
            // this.Owner.Enabled - true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_confirm_add_Click(sender, e);
        }
    }
}
