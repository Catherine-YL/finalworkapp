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
    public partial class Form10 : Form
    {
        private string rno;
        private string updateprosql = "update reader_info set";
        private string updateinfosql;

        public Form10()
        {
            InitializeComponent();
        }
        public Form10(string rno)
        {
            InitializeComponent();
            this.rno = rno;
            this.txt_rno.Text = rno;
        }

        private int bnt_change_readerinfo(string new_rno, string rname,string rsex,string rprofess,string rdpartmt,string rtel,string ravailable, string rborrowed)
        {
            int flag = 0;
            if (rno == "" && rname == "" && rsex == "" && rprofess == "" && rdpartmt == "" && rtel == "" && ravailable == "" && rborrowed == "")
            {
                return -1;
            }
            if (new_rno != "")
            {
                updateinfosql = updateprosql + " Rno='" + new_rno + "'";
                flag = 1;
            }
            if (rname != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Rname='" + rname + "'";
                flag = 1;
            }
            if (rsex != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Rsex='" + rsex + "'";
                flag = 1;
            }
            if (rprofess != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Rprofess='" + rprofess + "'";
                flag = 1;
            }
            if (rdpartmt != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Rdpartmt='" + rdpartmt + "'";
                flag = 1;
            }
            if (rtel != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Rtel='" + rtel + "'";
                flag = 1;
            }
            if (ravailable != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Ravailable=" + ravailable;
                flag = 1;
            }
            if (rborrowed != "")
            {
                if (flag == 1)
                {
                    updateinfosql = updateinfosql + ",";
                }
                updateinfosql = updateinfosql + " Rborrowed=" + rborrowed ;
                flag = 1;
            }
            updateinfosql = updateinfosql + " where Rno='" + rno + "'";
            return 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string new_rno = txt_rno.Text.Trim();
            string rname = txt_rname.Text.Trim();
            string rdpartmt = txt_rdpartmt.Text.Trim();
            string ravailable = txt_ravailable.Text.Trim();
            string rsex = txt_rsex.Text.Trim();
            string rprofess = txt_rprofess.Text.Trim();
            string rborrowed = txt_rborrowed.Text.Trim();
            string rtel = txt_rtel.Text.Trim();
            if(bnt_change_readerinfo(new_rno, rname, rsex, rprofess, rdpartmt, rtel, ravailable, rborrowed) < 0)
            {
                MessageBox.Show("请输入修改信息！");
                return;
            }
            if (Form4.ExecuteSql(updateinfosql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("未查询到要修改的读者，请检查输入!");
                return;
            }
        }
    }
}
