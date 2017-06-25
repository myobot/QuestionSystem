using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace question
{
    public partial class questionForm : Form
    {
        public questionForm()
        {
            InitializeComponent();
        }

        public string titleName;
        public int subjectid;
        public int questionNumber;
        public string[] answer = new string[20];
        string[] Tanswer = new string[20];
        string[] questions;
        string[] question = new string[20];
        bool[] Bquestion;
        int count = 0;
        public int index = 0;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        string connStr = "server=QZW;uid=qzw;pwd=4549689;database=MySchool";
        
        DataSet ds = new DataSet();
        checkForm ck = new checkForm();

        private void questionForm_Load(object sender, EventArgs e)
        {
            this.Text = "答题界面--" + titleName;
            
            randomInsert();
        }

        //随即抽取20道题目
        private void randomInsert()
        {
            string sql = "select * from question where subjectid=" + subjectid + "";
            sqlConnection = new SqlConnection(connStr);
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            sqlDataAdapter.Fill(ds, "question");
            int C = ds.Tables["question"].Rows.Count;
            questions = new string[C];
            Bquestion = new bool[C];
            for (int i = 0; i < C; i++)
            {
                questions[i] = ds.Tables["question"].Rows[i]["questionid"].ToString();
            }
            Random r = new Random();
            for (int i = 0; i < 20; )
            {
                int ran = r.Next(C);
                if (Bquestion[ran] == false)//判断Bquestion[ran]的值是否为false，若不是则表示此次产生的随机数ran对应的questionid
                                            //已交给过question数组~
                {
                    question[i] = questions[ran];//将随即产生的下标ran所对应的questionid交给question数组；
                    Bquestion[ran] = true;//将Bool型数组Bquestion所对应的ran下标的值设为true
                    i++;
                }
            }
            //循环将查找到的20道题目存入ds数据集中，待用！
            for (int i = 0; i < 20; i++)
            {
                string sql2 = "select * from question where questionid=" + Convert.ToInt32(question[i]) + "";
                sqlConnection = new SqlConnection(connStr);
                sqlDataAdapter = new SqlDataAdapter(sql2, sqlConnection);
                sqlDataAdapter.Fill(ds, "selectQuestion");
            }

            for (int j = 1; j <= 20; j++)
            {
                cboSubjectNumber.Items.Add(j);
                Tanswer[j - 1] = ds.Tables["selectQuestion"].Rows[j - 1]["answer"].ToString();//传递正确答案，已备后面判分对照用
            }
            btnLast.Enabled = false;
            cboSubjectNumber.SelectedIndex = 0;
            count = ds.Tables["selectQuestion"].Rows.Count;
            QuestionMethod();//QuestionMethod()方法不可放在用for循环给cboSubjectNumber赋值之前，
            //否则cboSubjectNumber中没有值，cboSubjectNumber.SelectedIndex = index;将无效
        }

        private void QuestionMethod()//查找并将question表里的信息加载到界面上
        {
            cboSubjectNumber.SelectedIndex = index;
            txtQuestion.Text = ds.Tables["selectQuestion"].Rows[index]["question"].ToString();
            txtA.Text = ds.Tables["selectQuestion"].Rows[index]["optionA"].ToString();
            txtB.Text = ds.Tables["selectQuestion"].Rows[index]["optionB"].ToString();
            txtC.Text = ds.Tables["selectQuestion"].Rows[index]["optionC"].ToString();
            txtD.Text = ds.Tables["selectQuestion"].Rows[index]["optionD"].ToString();
            int difficult = Convert.ToInt32(ds.Tables["selectQuestion"].Rows[index]["difficulty"]);
            if (difficult == 1)
            {
                rdb1.Checked = true;
                rdb2.Checked = false;
                rdb3.Checked = false;
            }
            else if (difficult == 2)
            {
                rdb1.Checked = false;
                rdb2.Checked = true;
                rdb3.Checked = false;
            }
            else if (difficult == 3)
            {
                rdb1.Checked = false;
                rdb2.Checked = false;
                rdb3.Checked = true;
            }
            else
            {

            }

            if (index == 0)
            {
                btnLast.Enabled = false;
                btnNext.Enabled = true;
            }
            else if (index == count-1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = true;
            }
            else
            {
                btnNext.Enabled = btnLast.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            index++;
            QuestionMethod();
            
            checkAnswer();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            
            index--;
            QuestionMethod();
            
            checkAnswer();
        }

        

        private void cboSubjectNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cboSubjectNumber.SelectedIndex;
            QuestionMethod();
            
            checkAnswer();
        }

        private void checkAnswer() {
            rdbA.Checked = rdbB.Checked = rdbC.Checked = rdbD.Checked = false;
        
            switch (answer[index]) { 
                case "A":
                    rdbA.Checked=true;
                    break;
                case "B":
                    rdbB.Checked = true;
                    break;
                case "C":
                    rdbC.Checked = true;
                    break;
                case "D":
                    rdbD.Checked = true;
                    break;
            }
        
        }

        private void chooseAnswer_click(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            answer[index] = rdb.Text;
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            ck = new checkForm();//每点击一次“检查试卷”时需要重新实例化，否则将造成数组越界，因为原先的数组已存放20个，                     
            ck.counts = count;
            ck.answer = answer;//不实例化则将继续向数组里添加20个值，造成数组越界！
            ck.trueAnswer = Tanswer;
            ck.ShowDialog();
            index = ck.index;
            checkAnswer();
            QuestionMethod();
           
        }
        
    }
}