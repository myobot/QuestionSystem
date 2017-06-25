using question.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question
{
    public partial class UpdateQuestionFrom : Form
    {
        public UpdateQuestionFrom()
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
                DialogResult dr = MessageBoxEx.Show(this, "确认更改？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr.ToString() == "Yes")
                {
                    QuestionInfoForm qif = new QuestionInfoForm();
                    qif.setQuestionid(questionid);
                    qif.father = this.father;
                    qif.StartPosition = FormStartPosition.CenterScreen;
                    qif.ShowDialog();
                }
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show(this, "请输入正确编号");
            }
        }
    }
}
