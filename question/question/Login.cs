using question.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace question
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UsernameTt.SetToolTip(UsernameText, "用户名");
            PasswordTt.SetToolTip(PasswordText, "密码");
            LoginTt.SetToolTip(LoginPan, "登录");
            UserModeTt.SetToolTip(UserMode, "用户类别");
            Student.Select();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.CloseBut.BackColor = Color.Red;
        }

        private void CloseBut_MouseLeave(object sender, EventArgs e)
        {
            this.CloseBut.BackColor = Color.Transparent;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registlab_MouseEnter(object sender, EventArgs e)
        {
            this.Registlab.ForeColor = Color.White;
        }

        private void Registlab_MouseLeave(object sender, EventArgs e)
        {
            this.Registlab.ForeColor = Color.Silver;
        }

        private void Registlab_Click(object sender, EventArgs e)
        {
            Regist r = new Regist();
            r.Location = this.Location;
            r.StartPosition = FormStartPosition.Manual;
            r.ShowDialog();
        }

        private void LoginPan_Click(object sender, EventArgs e)
        {
            String username = UsernameText.Text;
            String password = PasswordText.Text;
            if (Student.Checked)
            {
                userdao ud = new userdao();
                if (ud.findUser(username, password))
                {
                    DialogResult dr = MessageBoxEx.Show(this, "学生登录成功");
                    UserChooseForm ucf = new UserChooseForm();
                    ucf.username = username;
                    ucf.Location = this.Location;
                    ucf.StartPosition = FormStartPosition.Manual;
                    ucf.Show();
                }
                else
                {
                    DialogResult dr = MessageBoxEx.Show(this, "用户名密码错误，登录失败");
                }
            }
            else
            {
                admindao ad = new admindao();
                if (ad.findadmin(username, password))
                {
                    DialogResult dr = MessageBoxEx.Show(this, "管理员登录成功");
                    backspace bk = new backspace();
                    bk.Location = this.Location;
                    bk.StartPosition = FormStartPosition.Manual;
                    bk.Show();
                }
                else
                {
                    DialogResult dr = MessageBoxEx.Show(this, "用户名密码错误，登录失败");
                }
            }
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
