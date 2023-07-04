namespace WindowsFormsApp
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_rtel = new System.Windows.Forms.TextBox();
            this.txt_rdpartmt = new System.Windows.Forms.TextBox();
            this.txt_rprofess = new System.Windows.Forms.TextBox();
            this.txt_rsex = new System.Windows.Forms.TextBox();
            this.txt_rname = new System.Windows.Forms.TextBox();
            this.txt_rno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rborrowed = new System.Windows.Forms.TextBox();
            this.txt_ravailable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(311, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "点击添加读者";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入以下信息来添加一位读者：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_rborrowed);
            this.groupBox1.Controls.Add(this.txt_ravailable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_rtel);
            this.groupBox1.Controls.Add(this.txt_rdpartmt);
            this.groupBox1.Controls.Add(this.txt_rprofess);
            this.groupBox1.Controls.Add(this.txt_rsex);
            this.groupBox1.Controls.Add(this.txt_rname);
            this.groupBox1.Controls.Add(this.txt_rno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.姓名);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(29, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "填写读者信息";
            // 
            // txt_rtel
            // 
            this.txt_rtel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_rtel.Location = new System.Drawing.Point(485, 153);
            this.txt_rtel.Name = "txt_rtel";
            this.txt_rtel.Size = new System.Drawing.Size(236, 30);
            this.txt_rtel.TabIndex = 11;
            // 
            // txt_rdpartmt
            // 
            this.txt_rdpartmt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_rdpartmt.Location = new System.Drawing.Point(124, 153);
            this.txt_rdpartmt.Name = "txt_rdpartmt";
            this.txt_rdpartmt.Size = new System.Drawing.Size(236, 30);
            this.txt_rdpartmt.TabIndex = 10;
            // 
            // txt_rprofess
            // 
            this.txt_rprofess.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_rprofess.Location = new System.Drawing.Point(485, 92);
            this.txt_rprofess.Name = "txt_rprofess";
            this.txt_rprofess.Size = new System.Drawing.Size(236, 30);
            this.txt_rprofess.TabIndex = 9;
            // 
            // txt_rsex
            // 
            this.txt_rsex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_rsex.Location = new System.Drawing.Point(124, 95);
            this.txt_rsex.Name = "txt_rsex";
            this.txt_rsex.Size = new System.Drawing.Size(236, 30);
            this.txt_rsex.TabIndex = 8;
            // 
            // txt_rname
            // 
            this.txt_rname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_rname.Location = new System.Drawing.Point(485, 39);
            this.txt_rname.Name = "txt_rname";
            this.txt_rname.Size = new System.Drawing.Size(236, 30);
            this.txt_rname.TabIndex = 7;
            // 
            // txt_rno
            // 
            this.txt_rno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_rno.Location = new System.Drawing.Point(124, 39);
            this.txt_rno.Name = "txt_rno";
            this.txt_rno.Size = new System.Drawing.Size(236, 30);
            this.txt_rno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(378, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "联系电话";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "工作部门";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(418, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "职称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(36, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "性别";
            // 
            // 姓名
            // 
            this.姓名.AutoSize = true;
            this.姓名.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.姓名.Location = new System.Drawing.Point(418, 42);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(52, 27);
            this.姓名.TabIndex = 1;
            this.姓名.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "借书证号";
            // 
            // txt_rborrowed
            // 
            this.txt_rborrowed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_rborrowed.Location = new System.Drawing.Point(485, 209);
            this.txt_rborrowed.Name = "txt_rborrowed";
            this.txt_rborrowed.Size = new System.Drawing.Size(236, 30);
            this.txt_rborrowed.TabIndex = 15;
            // 
            // txt_ravailable
            // 
            this.txt_ravailable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ravailable.Location = new System.Drawing.Point(124, 209);
            this.txt_ravailable.Name = "txt_ravailable";
            this.txt_ravailable.Size = new System.Drawing.Size(236, 30);
            this.txt_ravailable.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(378, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "已借数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(16, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "可借数量";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form9";
            this.Text = "添加读者信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_rtel;
        private System.Windows.Forms.TextBox txt_rdpartmt;
        private System.Windows.Forms.TextBox txt_rprofess;
        private System.Windows.Forms.TextBox txt_rsex;
        private System.Windows.Forms.TextBox txt_rname;
        private System.Windows.Forms.TextBox txt_rno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label 姓名;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rborrowed;
        private System.Windows.Forms.TextBox txt_ravailable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}