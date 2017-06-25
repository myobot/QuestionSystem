using question.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace question
{
    public partial class delQuestionFrom : Form
    {
        public delQuestionFrom()
        {
            InitializeComponent();
        }
        backspace father = null;
        public void setFather(backspace fa)
        {
            this.father = fa;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int questionid = int.Parse(textBox1.Text);
                DialogResult dr = MessageBoxEx.Show(this, "确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr.ToString() == "Yes")
                {
                    questiondao qd = new questiondao();
                    if (qd.DeleteQuestion(questionid))
                    {
                        MessageBoxEx.Show(this, "删除成功");
                        father.filldata();

                    }
                    else
                    {
                        MessageBoxEx.Show(this, "删除失败");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show(this, "请输入正确编号");
            }
        }
    }
}
