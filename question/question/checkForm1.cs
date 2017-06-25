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
    public partial class checkForm1 : Form
    {
        String[] answer = null;
        public int index = 0;
        public QuestionForm1 fa = null;

        public checkForm1()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void CloseBut_MouseEnter(object sender, EventArgs e)
        {
            this.CloseBut.BackColor = Color.Red;
        }

        private void CloseBut_MouseLeave(object sender, EventArgs e)
        {
            this.CloseBut.BackColor = Color.Transparent;
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool _0 = true,_1=true,_2=true,_3=true,_4=true,_5=true,_6=true,_7=true,_8=true,_9=true;

        private void Number7_Click(object sender, EventArgs e)
        {
            if (_7)
            {
                this.index = 7;
                fa.index = 7;
                this.Close();
            }
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if (_8)
            {
                this.index = 8;
                fa.index = 8;
                this.Close();
            }
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if (_9)
            {
                this.index = 9;
                fa.index = 9;
                this.Close();
            }
        }

        private void checkForm1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if (_6)
            {
                this.index = 6;
                fa.index = 6;
                this.Close();
            }
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if (_5)
            {
                this.index = 5;
                fa.index = 5;
                this.Close();
            }
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            if (_4)
            {
                this.index = 4;
                fa.index = 4;
                this.Close();
            }
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            if (_3)
            {
                this.index = 3;
                fa.index = 3;
                this.Close();
            }
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            if (_2)
            {
                this.index = 2;
                fa.index = 2;
                this.Close();
            }
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            if (_1)
            {
                this.index = 1;
                fa.index = 1;
                this.Close();
            }
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            if (_0)
            {
                this.index = 0;
                fa.index = 0;
                this.Close();
            }
        }

        public void changeStat(int n)
        {
            switch (n)
            {
                case 0: _0 = false; Number0.BackgroundImage = Properties.Resources._0__1_; Number0.Cursor = Cursors.Hand; break;
                case 1: _1 = false; Number1.BackgroundImage = Properties.Resources._1__1_; Number1.Cursor = Cursors.Hand; break;
                case 2: _2 = false; Number2.BackgroundImage = Properties.Resources._2__1_; Number2.Cursor = Cursors.Hand; break;
                case 3: _3 = false; Number3.BackgroundImage = Properties.Resources._3__1_; Number3.Cursor = Cursors.Hand; break;
                case 4: _4 = false; Number4.BackgroundImage = Properties.Resources._4__1_; Number4.Cursor = Cursors.Hand; break;
                case 5: _5 = false; Number5.BackgroundImage = Properties.Resources._5__1_; Number5.Cursor = Cursors.Hand; break;
                case 6: _6 = false; Number6.BackgroundImage = Properties.Resources._6__1_; Number6.Cursor = Cursors.Hand; break;
                case 7: _7 = false; Number7.BackgroundImage = Properties.Resources._7__1_; Number7.Cursor = Cursors.Hand; break;
                case 8: _8 = false; Number8.BackgroundImage = Properties.Resources._8__1_; Number8.Cursor = Cursors.Hand; break;
                case 9: _9 = false; Number9.BackgroundImage = Properties.Resources._9__1_; Number9.Cursor = Cursors.Hand; break;
                default:break;
            }
        }
        public void setAnswer(String[] answer)
        {
            this.answer = answer;
            bool flag = true;
            for(int i = 0; i < answer.Length; i++)
            {
                if (answer[i] != null)
                {
                    flag = false;
                    changeStat(i);
                }
            }
            if (flag)
            {
                label1.Visible = true;
            }
        }
    }
}
