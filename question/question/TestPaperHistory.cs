using question.dao;
using question.vo;
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
    public partial class TestPaperHistory : Form
    {
        public String username { get; set; }

        public TestPaperHistory()
        {
            InitializeComponent();
            
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public void setUsername(String username)
        {
            scoredao sd = new scoredao();
            List<score> s = sd.getScoreList(username);
            int ly = 0;
            for (int i = 0; i < s.Count; i++)
            {
                TestPaper tp = new TestPaper();
                tp.setAll(i, s[i].tpid, username, s[i].sc);
                tp.Location = new Point(0, ly);
                ly += 40;
                this.panel1.Controls.Add(tp);
            }
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

        private void TestPaperHistory_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
