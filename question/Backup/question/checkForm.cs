using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace question
{
    public partial class checkForm : Form
    {
        public checkForm()
        {
            InitializeComponent();
        }
        public int counts;
        public string[] answer=new string[20];
        public string[] trueAnswer = new string[20];
        public int index;
        private void checkForm_Load(object sender, EventArgs e)
        {
            btnInfo();
            checkAnswer();
        }

        private void btnInfo() {
            int x = 20; int y = 20;
            for (int i = 1; i <= counts;i++ )
            {
                Button btn = new Button();
                btn.Size = new Size(60,60);
                btn.Location = new Point(x,y);
                btn.Name = i.ToString();
                btn.Text = i + "." + "未回答";
                btn.Tag = i;
                x += 70;
                if(i%5==0){
                    x = 20;
                    y += 70;
                }
                btn.Click += new EventHandler(btn_Click);
                groupBox1.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            index = Convert.ToInt32(btn.Tag)-1;
            this.Close();
        }

        private void checkAnswer() { 
            int i=0;
            foreach(Control cn in groupBox1.Controls ){
                Button btn = (Button)cn;
                if(answer[i]!=null){
                    btn.Text = (i + 1) + "." + answer[i];   
                }
                i++;
            }
        }

        private int chkAnswer() {
            int count = 100;
            for (int i = 0; i < counts;i++ )
            {
                if (answer[i] != trueAnswer[i])
                {
                    count -= 5;
                }
            }
            return count;
            
        }

        private void btnJiaoJuan_Click(object sender, EventArgs e)
        {
            int i = chkAnswer();
            DialogResult result = MessageBox.Show("您的得分为" + i + "分" + "||" + "按确定退出考试系统");
            if(result==DialogResult.OK){
                Environment.Exit(0);
            }
        }
    }
}