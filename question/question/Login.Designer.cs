namespace question
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserMode = new System.Windows.Forms.GroupBox();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.Registlab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTt = new System.Windows.Forms.ToolTip(this.components);
            this.PasswordTt = new System.Windows.Forms.ToolTip(this.components);
            this.LoginTt = new System.Windows.Forms.ToolTip(this.components);
            this.UserModeTt = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginPan = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.UserMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameText
            // 
            this.UsernameText.Font = new System.Drawing.Font("等线", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UsernameText.Location = new System.Drawing.Point(138, 102);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(234, 35);
            this.UsernameText.TabIndex = 3;
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("等线", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordText.Location = new System.Drawing.Point(138, 160);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(234, 35);
            this.PasswordText.TabIndex = 4;
            // 
            // UserMode
            // 
            this.UserMode.BackColor = System.Drawing.Color.Transparent;
            this.UserMode.Controls.Add(this.Student);
            this.UserMode.Controls.Add(this.Admin);
            this.UserMode.Location = new System.Drawing.Point(138, 210);
            this.UserMode.Name = "UserMode";
            this.UserMode.Size = new System.Drawing.Size(234, 42);
            this.UserMode.TabIndex = 6;
            this.UserMode.TabStop = false;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Student.ForeColor = System.Drawing.Color.White;
            this.Student.Location = new System.Drawing.Point(157, 14);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(58, 21);
            this.Student.TabIndex = 1;
            this.Student.Text = "学生";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(21, 14);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(74, 21);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "管理员";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Registlab
            // 
            this.Registlab.AutoSize = true;
            this.Registlab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registlab.Font = new System.Drawing.Font("等线", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Registlab.ForeColor = System.Drawing.Color.Silver;
            this.Registlab.Location = new System.Drawing.Point(145, 373);
            this.Registlab.Name = "Registlab";
            this.Registlab.Size = new System.Drawing.Size(180, 19);
            this.Registlab.TabIndex = 12;
            this.Registlab.Text = "还没账号？点此注册";
            this.Registlab.Click += new System.EventHandler(this.Registlab_Click);
            this.Registlab.MouseEnter += new System.EventHandler(this.Registlab_MouseEnter);
            this.Registlab.MouseLeave += new System.EventHandler(this.Registlab_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "用户登录";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::question.Properties.Resources.类型;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(102, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::question.Properties.Resources.密码;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(102, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::question.Properties.Resources.用户名;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(99, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPan
            // 
            this.LoginPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(121)))), ((int)(((byte)(173)))));
            this.LoginPan.BackgroundImage = global::question.Properties.Resources.登录__1_;
            this.LoginPan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginPan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginPan.Location = new System.Drawing.Point(102, 278);
            this.LoginPan.Name = "LoginPan";
            this.LoginPan.Size = new System.Drawing.Size(270, 40);
            this.LoginPan.TabIndex = 8;
            this.LoginPan.Click += new System.EventHandler(this.LoginPan_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.BackColor = System.Drawing.Color.Transparent;
            this.CloseBut.BackgroundImage = global::question.Properties.Resources.关闭__4_;
            this.CloseBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBut.Location = new System.Drawing.Point(455, 4);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(24, 24);
            this.CloseBut.TabIndex = 0;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            this.CloseBut.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.CloseBut.MouseLeave += new System.EventHandler(this.CloseBut_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(156)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registlab);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginPan);
            this.Controls.Add(this.UserMode);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.CloseBut);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.UserMode.ResumeLayout(false);
            this.UserMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBut;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.GroupBox UserMode;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.Panel LoginPan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Registlab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip UsernameTt;
        private System.Windows.Forms.ToolTip PasswordTt;
        private System.Windows.Forms.ToolTip LoginTt;
        private System.Windows.Forms.ToolTip UserModeTt;
    }
}