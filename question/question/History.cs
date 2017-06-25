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
    public partial class History : Form
    {
        int index = 0;
        
        List<Question> q = null;
        List<history> h = null;

        
        public int tpid { get; set; }
        public String username { get; set; }

        
        public History()
        {
            InitializeComponent();
           
        }
       

        public void LoadQuestion()
        {
            this.QuestionText.Text = q[index].q_name;
            this.AText.Text = q[index].c_a;
            this.BText.Text = q[index].c_b;
            this.CText.Text = q[index].c_c;
            this.DText.Text = q[index].c_d;
            this.Level1.BackgroundImage = Properties.Resources.课后作业_难度1__2_;
            this.Level2.BackgroundImage = Properties.Resources.课后作业_难度2__2_;
            this.Level3.BackgroundImage = Properties.Resources.课后作业_难度3__2_;
            this.Level4.BackgroundImage = Properties.Resources.课后作业_难度4__2_;
            this.Level5.BackgroundImage = Properties.Resources.课后作业_难度5__2_;
            this.YES.Text = q[index].answer;
            this.YOUR.Text = h[index].useranswer;
            this.Score.Text = q[index].score.ToString();
            if (h[index].rightorwrong == 0)
            {
                this.YourScore.Text = "0";
            }else
            {
                this.YourScore.Text = q[index].score.ToString();
            }
            switch (q[index].hardlevel)
            {
                case 1: this.Level1.BackgroundImage = Properties.Resources.课后作业_难度1; break;
                case 2: this.Level2.BackgroundImage = Properties.Resources.课后作业_难度2; break;
                case 3: this.Level3.BackgroundImage = Properties.Resources.课后作业_难度3; break;
                case 4: this.Level4.BackgroundImage = Properties.Resources.课后作业_难度4; break;
                case 5: this.Level5.BackgroundImage = Properties.Resources.课后作业_难度5; break;
                default: this.Level1.BackgroundImage = Properties.Resources.课后作业_难度1; break;
            }
            
            if (index == 9)
            {
                this.NextBut2.BackgroundImage = Properties.Resources.icon_下一题__1_;
                this.NextBut3.ForeColor = Color.FromArgb(138, 138, 138);
                this.NextBut1.Cursor = Cursors.Default;
                this.NextBut2.Cursor = Cursors.Default;
                this.NextBut3.Cursor = Cursors.Default;
                choosenextflag = true;
            }
            else if (index == 0)
            {
                this.LastBut2.BackgroundImage = Properties.Resources.icon_上一题__1_;
                this.LastBut3.ForeColor = Color.FromArgb(138, 138, 138);
                this.LastBut1.Cursor = Cursors.Default;
                this.LastBut2.Cursor = Cursors.Default;
                this.LastBut3.Cursor = Cursors.Default;
                chooselastflag = true;
            }
            else
            {
                if (choosenextflag)
                {
                    this.NextBut2.BackgroundImage = Properties.Resources.icon_下一题;
                    this.NextBut3.ForeColor = Color.White;
                    this.NextBut1.Cursor = Cursors.Hand;
                    this.NextBut2.Cursor = Cursors.Hand;
                    this.NextBut3.Cursor = Cursors.Hand;
                }
                if (chooselastflag)
                {
                    this.LastBut2.BackgroundImage = Properties.Resources.icon_上一题;
                    this.LastBut3.ForeColor = Color.White;
                    this.LastBut1.Cursor = Cursors.Hand;
                    this.LastBut2.Cursor = Cursors.Hand;
                    this.LastBut3.Cursor = Cursors.Hand;
                }
            }
        }
        
        public void changeNum()
        {
            switch (index)
            {
                case 1: this.NumberLab.BackgroundImage = Properties.Resources._1; break;
                case 2: this.NumberLab.BackgroundImage = Properties.Resources._2; break;
                case 3: this.NumberLab.BackgroundImage = Properties.Resources._3; break;
                case 4: this.NumberLab.BackgroundImage = Properties.Resources._4; break;
                case 5: this.NumberLab.BackgroundImage = Properties.Resources._5; break;
                case 6: this.NumberLab.BackgroundImage = Properties.Resources._6; break;
                case 7: this.NumberLab.BackgroundImage = Properties.Resources._7; break;
                case 8: this.NumberLab.BackgroundImage = Properties.Resources._8; break;
                case 9: this.NumberLab.BackgroundImage = Properties.Resources._9; break;
                case 0: this.NumberLab.BackgroundImage = Properties.Resources._0; break;
                default: break;

            }
        }
        public void NextQuestion()
        {
            if (index == 9) { }
            /* else if (index == 8)
             {
                 Check();
                 index++;
                 this.LoadQuestion();
                 this.NextBut2.BackgroundImage = Properties.Resources.icon_下一题__1_;
                 this.NextBut3.ForeColor = Color.FromArgb(138, 138, 138);
                 this.NextBut1.Cursor = Cursors.Default;
                 this.NextBut2.Cursor = Cursors.Default;
                 this.NextBut3.Cursor = Cursors.Default;
                 changeNum();
             }
             else if (index == 0)
             {
                 Check();
                 index++;
                 this.LoadQuestion();
                 this.LastBut2.BackgroundImage = Properties.Resources.icon_上一题;
                 this.LastBut3.ForeColor = Color.White;
                 this.LastBut1.Cursor = Cursors.Hand;
                 this.LastBut2.Cursor = Cursors.Hand;
                 this.LastBut3.Cursor = Cursors.Hand;
                 changeNum();
             }
             */
            else
            {
               
                index++;
                this.LoadQuestion();
                changeNum();
            }

        }
        public void LastQuestion()
        {
            if (index == 0) { }
            /* else if (index == 1)
             {
                 Check();
                 index--;
                 this.LoadQuestion();
                 this.LastBut2.BackgroundImage = Properties.Resources.icon_上一题__1_;
                 this.LastBut3.ForeColor = Color.FromArgb(138, 138, 138);
                 this.LastBut1.Cursor = Cursors.Default;
                 this.LastBut2.Cursor = Cursors.Default;
                 this.LastBut3.Cursor = Cursors.Default;
                 changeNum();

             }
             else if (index == 9)
             {
                 Check();
                 index--;
                 this.LoadQuestion();
                 this.NextBut2.BackgroundImage = Properties.Resources.icon_下一题;
                 this.NextBut3.ForeColor = Color.White;
                 this.NextBut1.Cursor = Cursors.Hand;
                 this.NextBut2.Cursor = Cursors.Hand;
                 this.NextBut3.Cursor = Cursors.Hand;
                 changeNum();
             }
             */
            else
            {
                
                index--;
                this.LoadQuestion();
                changeNum();

            }
        }
        private void NextBut1_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void LastBut1_Click(object sender, EventArgs e)
        {
            LastQuestion();
        }

        private void NextBut2_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void NextBut3_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void LastBut2_Click(object sender, EventArgs e)
        {
            LastQuestion();
        }

        private void LastBut3_Click(object sender, EventArgs e)
        {
            LastQuestion();
        }
        bool choosenextflag = false;
        bool chooselastflag = false;
        private void ChooseNumBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            index = ChooseNumBox.SelectedIndex;
            LoadQuestion();

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

        private void History_Load(object sender, EventArgs e)
        {
            questiondao qd = new questiondao();
            q = qd.getQuestionList();
            historydao hd = new historydao();
            h = hd.getHistoryList(username, tpid);
            for (int i = 0; i < h.Count; i++)
            {
                ChooseNumBox.Items.Add(i);
            }
            
            q = new List<Question>();

            for (int i = 0; i < h.Count; i++)
            {
                Question qu = qd.getQuestion(h[i].questionid);
                q.Add(qu);
            }
            LoadQuestion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
       
        private void History_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
