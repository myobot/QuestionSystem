using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using question.vo;
using question.dao;
using System.Runtime.InteropServices;

namespace question
{
    public partial class QuestionForm1 : Form
    {
        public int index = 0;
        List<Question> q = null;
        String[] answer = new String[10];
        public String username { get; set; }
        
        public QuestionForm1()
        {
            InitializeComponent();
            questiondao qd = new questiondao();
            q = qd.getQuestionList();
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = null;
                ChooseNumBox.Items.Add(i);
            }
            ABut.Checked = false;
            LoadQuestion();
            
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
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
            switch (q[index].hardlevel)
            {
                case 1: this.Level1.BackgroundImage = Properties.Resources.课后作业_难度1; break;
                case 2: this.Level2.BackgroundImage = Properties.Resources.课后作业_难度2; break;
                case 3: this.Level3.BackgroundImage = Properties.Resources.课后作业_难度3; break;
                case 4: this.Level4.BackgroundImage = Properties.Resources.课后作业_难度4; break;
                case 5: this.Level5.BackgroundImage = Properties.Resources.课后作业_难度5; break;
                default: this.Level1.BackgroundImage = Properties.Resources.课后作业_难度1; break;
            }
            if (answer[index] != null)
            {
                if (answer[index] == "A")
                {
                    ABut.Select();
                }
                if (answer[index] == "B")
                {
                    BBut.Select();
                }
                if (answer[index] == "C")
                {
                    CBut.Select();
                }
                if (answer[index] == "D")
                {
                    DBut.Select();
                }
            }else
            {
                ABut.Checked = false;
                BBut.Checked = false;
                CBut.Checked = false;
                DBut.Checked = false;
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
            changeNum();
            
        }
        public void Check()
        {
            if (this.ABut.Checked)
            {
                answer[index] = "A";
            }
            else if (this.BBut.Checked)
            {
                answer[index] = "B";
            }
            else if (this.CBut.Checked)
            {
                answer[index] = "C";
            }
            else if (this.DBut.Checked)
            {
                answer[index] = "D";
            }
            else
            {
                answer[index] = null;
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
                Check();
                index++;
                this.LoadQuestion();
               
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
                Check();
                index--;
                this.LoadQuestion();
                
               
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
            Check();
            index = ChooseNumBox.SelectedIndex;
            LoadQuestion();            
        }
        public void OpenCheckForm()
        {
            Check();
            checkForm1 ck = new checkForm1();
            ck.Location = new Point(this.Location.X+(this.Size.Width-ck.Size.Width)/2,this.Location.Y+(this.Height-ck.Height)/2 );
            ck.StartPosition = FormStartPosition.Manual;
            ck.fa = this;
            ck.setAnswer(answer);
            ck.ShowDialog();
            //this.index = ck.index;
            this.LoadQuestion();
        }

        private void CheckAnswer2_Click(object sender, EventArgs e)
        {
            OpenCheckForm();
        }

        private void CheckAnswer1_Click(object sender, EventArgs e)
        {
            OpenCheckForm();
        }

        private void CheckAnswer3_Click(object sender, EventArgs e)
        {
            OpenCheckForm();

        }
        public int sumScore()
        {
            int sum = 0;
            for(int i = 0; i < answer.Length; i++)
            {
                if (answer[i].Equals(q[i].answer))
                {
                    sum += q[i].score;
                }

            }
            return sum;
        }
        public void Submit()
        {
            Check();
            bool flag = true;
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == null)
                {
                    flag = false;
                    break;
                }
            }
            if (!flag)
            {
                DialogResult dr = MessageBoxEx.Show(this, "试卷未完成，无法交卷","提示");
            }
            else
            {
                DialogResult dr = MessageBoxEx.Show(this, "确认交卷？","提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr.ToString()== "Yes")
                {
                    int sum = sumScore();
                    MessageBoxEx.Show(this, "交卷完毕\n得分：" + sum);
                    history[] h = new history[answer.Length];
                    score s = new score();
                    countdao cd = new countdao();
                    int tpcount = cd.getTpCount();
                    s.tpid = tpcount;
                    s.sc = sum;
                    s.username = this.username;
                    historydao hd = new historydao();
                    for(int i = 0; i < h.Length; i++)
                    {
                        h[i] = new history();
                        h[i].username = this.username;
                        h[i].questionid = this.q[i].questionid;
                        h[i].useranswer = this.answer[i];
                        if (answer[i] != this.q[i].answer)
                        {
                            h[i].rightorwrong = 0;
                        }
                        else
                        {
                            h[i].rightorwrong = 1;
                        }
                        h[i].tpid = tpcount;
                        hd.insterHistory(h[i]);
                    }
                    scoredao sd = new scoredao();
                    sd.insertScore(s);
                    this.Close();
                }
            }

        }

        private void Submit1_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void Submit3_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void Submit2_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBut_MouseDown(object sender, MouseEventArgs e)
        {
            this.CloseBut.BackColor = Color.Red;
        }

        private void CloseBut_MouseLeave(object sender, EventArgs e)
        {
            this.CloseBut.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void QuestionForm1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void QuestionForm1_Load(object sender, EventArgs e)
        {
            ABut.Checked = false;
        }
    }
}
