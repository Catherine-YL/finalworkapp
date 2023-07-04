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
    public partial class Form8 : Form
    {
        private string bno;
        private string updateprosql = "update book_info set";
        private string updateinfosql;
        public Form8()
        {
            InitializeComponent();
        }
        public Form8(string bno)
        {
            InitializeComponent();
            this.bno = bno;
        }
        private int bnt_change_bookinfo(string new_bno, string bname, string bpub, string bauthor, string bsumnum, string bavailable)
        {
            int flag = 0;   // 用于标识前面是否有非空修改属性
            if (new_bno==""&& bname=="" && bpub=="" && bauthor=="" && bsumnum=="" && bavailable=="")
            {
                return -1;
            }
            if (new_bno != "")
            {
                updateinfosql = updateprosql + " Bno='" + new_bno + "'";
                flag = 1;
            }
            if (bname != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Bname='" + bname + "'";
                flag = 1;
            }
            if (bpub != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Bpub='" + bpub + "'";
                flag = 1;
            }
            if (bauthor != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Bauthor='" + bauthor + "'";
                flag = 1;
            }
            if (bsumnum != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Bsumnum=" + bsumnum;
                flag = 1;
            }
            if (bavailable != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Bavailable=" + bavailable;
                flag = 1;
            }
            updateinfosql = updateinfosql + " where Bno='" + bno + "'";
            return 0;
        }

        private void txt_bno_TextChanged(object sender, EventArgs e)
        {
            bno = txt_bno.Text.Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bno = txt_bno.Text.Trim();
            string bname = txt_bname.Text.Trim();
            string bpub = txt_bpub.Text.Trim();
            string bauthor = txt_bauthor.Text.Trim();
            string bsumnum = txt_bsumnum.Text.Trim();
            string bavailable = txt_bavailable.Text.Trim();
            if(bnt_change_bookinfo(bno, bname, bpub, bauthor, bsumnum, bavailable) < 0)
            {
                MessageBox.Show("请输入要修改的信息!");
                return;
            }
            if (Form3.ExecuteSql(updateinfosql)>0)
            {
                MessageBox.Show("修改成功!");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("未查询到要修改的书目，请检查输入!");
                return;
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.txt_bno.Text = bno;
        }
    }
}
