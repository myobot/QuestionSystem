using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace question
{
    public partial class TestPaper : UserControl
    {
        int index = 0;
        int tpid;
        String username;
        int totalscore = 0;
        public TestPaper()
        {
            InitializeComponent();
        }
        public void setAll(int index,int tpid,String username,int s)
        {
            this.index = index;
            this.tpid = tpid;
            this.username = username;
            this.label1.Text = "试卷" + index;
            this.totalscore = s;
            this.label2.Text = "得分：" + totalscore;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.tpid = this.tpid;
            h.username = this.username;
            h.Show();
        }

        private void TestPaper_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.tpid = this.tpid;
            h.username = this.username;
            h.Show();
        }
    }
}
