using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace question
{
    public partial class backspace : Form
    {
        public backspace()
        {
            InitializeComponent();
            filldata();
        }
        DataSet ds=null;
        public void filldata()
        {
            string sql = "SELECT * From question";
            ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sql, null);
            bindingSource1.DataSource = ds.Tables[0];
            this.dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].HeaderText = "编号";
            dataGridView1.Columns[1].HeaderText = "题干";
            dataGridView1.Columns[2].HeaderText = "选项A";
            dataGridView1.Columns[3].HeaderText = "选项B";
            dataGridView1.Columns[4].HeaderText = "选项C";
            dataGridView1.Columns[5].HeaderText = "选项D";
            dataGridView1.Columns[6].HeaderText = "难度等级";
            dataGridView1.Columns[7].HeaderText = "分数";
            dataGridView1.Columns[8].HeaderText = "答案";
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestionInfoForm qif = new QuestionInfoForm();
            qif.StartPosition = FormStartPosition.CenterScreen;
            qif.father = this;
            qif.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delQuestionFrom dqf = new delQuestionFrom();
            dqf.setFather(this);
            dqf.StartPosition = FormStartPosition.CenterScreen;
            dqf.ShowDialog();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateQuestionFrom uqf = new UpdateQuestionFrom();
            uqf.StartPosition = FormStartPosition.CenterScreen;
            uqf.setFather(this);
            uqf.ShowDialog();
        }

       
    }
}
