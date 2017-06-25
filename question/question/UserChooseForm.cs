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
    public partial class UserChooseForm : Form
    {
        public String username { get; set; }
        public UserChooseForm()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public void dotest()
        {
            QuestionForm1 qf = new QuestionForm1();
            qf.username = username;
            qf.StartPosition = FormStartPosition.CenterScreen;
            qf.Show();
        }
        public void lookhistory()
        {
            TestPaperHistory tph = new TestPaperHistory();
            tph.setUsername(username);
            tph.Location = this.Location;
            tph.StartPosition = FormStartPosition.Manual;
            tph.Show();
            
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBut_MouseEnter(object sender, EventArgs e)
        {
            this.CloseBut.BackColor = Color.Red;
        }

        private void CloseBut_MouseLeave(object sender, EventArgs e)
        {
            this.CloseBut.BackColor = Color.Transparent;
        }

        private void LoginPan_Click(object sender, EventArgs e)
        {
            dotest();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dotest();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dotest();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            lookhistory();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lookhistory();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lookhistory();
        }

        private void UserChooseForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
