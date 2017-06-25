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
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
            UsernameTt.SetToolTip(UsernameText, "用户名");
            PasswordTt.SetToolTip(PasswordText, "密码");
            RePasswordTt.SetToolTip(RePasswordText, "确认密码");
            SexTt.SetToolTip(Sex, "性别");
            ClassTt.SetToolTip(ClassText, "班级");
            UserQuestionTt.SetToolTip(UserQuestion, "密保问题");
            AnswerTt.SetToolTip(Answer, "答案");
            UserQuestion.Items.Add("您目前的姓名是？");
            UserQuestion.Items.Add("您的学号（或工号）是？");
            UserQuestion.Items.Add("您母亲的生日是？");
            UserQuestion.Items.Add("您高中班主任的名字是？");
            UserQuestion.Items.Add("您父亲的姓名是？");
            UserQuestion.Items.Add("您小学班主任的名字是？");
            UserQuestion.Items.Add("您父亲的生日是？");
            UserQuestion.Items.Add("您初中班主任的名字是？");
            UserQuestion.Items.Add("您最熟悉的童年好友名字是？");
            UserQuestion.Items.Add("您最熟悉的学校宿舍舍友名字是？");
            UserQuestion.Items.Add("对您影响最大的人名字是？");
            UserQuestion.Text = "请选择或输入密保问题";
            Man.Select();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void CloseBut_MouseEnter(object sender, EventArgs e)
        {
            this.CloseBut.BackColor = Color.Red;
        }

        private void CloseBut_MouseLeave(object sender, EventArgs e)
        {
            this.CloseBut.BackColor = Color.Transparent;
        }

        private void RegistPan_Click(object sender, EventArgs e)
        {
            String username = UsernameText.Text;
            String password = PasswordText.Text;
            String repassword = RePasswordText.Text;
            int Sex = 1;
            if (Man.Checked)
            {
                Sex = 1;
            }
            if (Woman.Checked)
            {
                Sex = 2;
            }
            String c = ClassText.Text;
            String question = UserQuestion.Text;
            String answer = Answer.Text;
            if (repassword != password)
            {
                DialogResult dr = MessageBoxEx.Show(this, "两次密码输入不一致");
                RePasswordText.Focus();
            }
            else if (username == null || "".Equals(username) || password == null || "".Equals(password))
            {
                DialogResult dr = MessageBoxEx.Show(this, "用户名和密码不能为空");
                UsernameText.Focus();
            }
            else if(question== "请选择或输入密保问题")
            {
                DialogResult dr = MessageBoxEx.Show(this, "请选择或输入密保问题");
                UserQuestion.Focus();
            }
            else if (answer == null || "".Equals(answer))
            {
                DialogResult dr = MessageBoxEx.Show(this, "密保答案不能为空");
                Answer.Focus();
            }
            else
            {
                user u = new user();
                u.username = username;
                u.password = password;
                u.sex = Sex;
                u.Class = c;
                u.question = question;
                u.answer = answer;
                userdao ud = new userdao();
                if (ud.addUser(u))
                {
                    DialogResult dr = MessageBoxEx.Show(this, "注册成功");
                    this.Close();
                }
                else
                {
                    DialogResult dr = MessageBoxEx.Show(this, "注册失败");
                }
            }
           
        }

        private void Regist_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
