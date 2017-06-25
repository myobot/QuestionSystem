using question.dao;
using question.vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace question
{
    public partial class QuestionInfoForm : Form
    {
        public backspace father = null;
        public QuestionInfoForm()
        {
            InitializeComponent();
        }
        public int questionid = -1;
        public void setQuestionid(int questionid)
        {
            this.questionid = questionid;
            questiondao qd = new questiondao();
            Question q = qd.getQuestion(questionid);
            q_name.Text = q.q_name;
            c_a.Text = q.c_a;
            c_b.Text = q.c_b;
            c_c.Text = q.c_c;
            c_d.Text = q.c_d;
            if (q.answer == "A") { A.Select(); }
            if (q.answer == "B") { B.Select(); }
            if (q.answer == "C") { C.Select(); }
            if (q.answer == "D") { D.Select(); }

            if (q.hardlevel == 1) { level1.Select(); }
            if (q.hardlevel == 2) { level2.Select(); }
            if (q.hardlevel == 3) { level3.Select(); }
            if (q.hardlevel == 4) { level4.Select(); }
            if (q.hardlevel == 5) { level5.Select(); }

            score.Text = q.score.ToString();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (q_name.Text == "" || c_a.Text == "" || c_b.Text == "" || c_c.Text == "" || c_d.Text == "" || score.Text == "")
            {
                flag = false;
            }
            int hardlevel = -1;
            if (level1.Checked)
            {
                hardlevel = 1;
            }
            if (level2.Checked)
            {
                hardlevel = 2;
            }
            if (level3.Checked)
            {
                hardlevel = 3;
            }
            if (level4.Checked)
            {
                hardlevel = 4;
            }
            if (level5.Checked)
            {
                hardlevel = 5;
            }
            if (hardlevel == -1)
            {
                flag = false;
            }
            String s = null;
            if (A.Checked)
            {
                s = "A";
            }
            if (B.Checked)
            {
                s = "B";
            }
            if (C.Checked)
            {
                s = "C";
            }
            if (D.Checked)
            {
                s = "D";
            }
            if (s == null)
            {
                flag = false;
            }

            if (flag)
            {
                DialogResult dr = MessageBoxEx.Show(this, "确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr.ToString() == "Yes")
                {
                    try
                    {
                        Question q = new Question();
                        q.q_name = q_name.Text;
                        q.c_a = c_a.Text;
                        q.c_b = c_b.Text;
                        q.c_c = c_c.Text;
                        q.c_d = c_d.Text;
                        q.hardlevel = hardlevel;
                        q.score = int.Parse(score.Text);
                        q.answer = s;
                        questiondao qd = new questiondao();
                        if (questionid != -1)
                        {
                            q.questionid = questionid;
                            qd.UpdateQuetion(q);
                            father.filldata();
                            this.Close();
                        }
                        else
                        {
                            qd.insertQuestion(q);
                            father.filldata();
                            this.Close();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBoxEx.Show(this, "请输如正确分数");
                    }
                }
            }
            else
            {
                MessageBoxEx.Show(this, "有空项，请检查后再提交！");
            }
        }
    }
}
