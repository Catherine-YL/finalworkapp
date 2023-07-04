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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn_confirm_add_Click(object sender, EventArgs e)
        {
            string bno = txt_bno.Text.Trim(); //获取Form2中文本框txt_add_sid的值，并去除结尾的空字符
            string bname = txt_bname.Text.Trim();
            string bpub = txt_bpub.Text.Trim();
            string bauthor = txt_bauthor.Text.Trim();
            string bsumnum = txt_bsumnum.Text.Trim();
            string bavailable = txt_bavailable.Text.Trim();
            string sql = "insert into book_info values('" + bno + "','" + bname + "','" + bpub + "','" + bauthor + "'," + bsumnum + "," + bavailable + ",'可借')";
            if (Form3.ExecuteSql(sql)>0)
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
