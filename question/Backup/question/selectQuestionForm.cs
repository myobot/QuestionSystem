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
    public partial class selectQuestionForm : Form
    {
        public selectQuestionForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        string connStr = "server=QZW;uid=qzw;pwd=4549689;database=MySchool";
        private void selectQuestionForm_Load(object sender, EventArgs e)
        {
            string sql="select subjectid,subjectname from subject";
            sqlConnection = new SqlConnection(connStr);
            sqlDataAdapter=new SqlDataAdapter(sql,sqlConnection);
            DataSet ds=new DataSet();
            sqlDataAdapter.Fill(ds,"subject");
            cboSelect.DataSource=ds.Tables["subject"];
            cboSelect.DisplayMember="subjectname";
            cboSelect.ValueMember="subjectid";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            questionForm mm = new questionForm();
            mm.titleName = cboSelect.Text;
            mm.subjectid = Convert.ToInt32(cboSelect.SelectedValue);
            mm.Show();
            this.Visible = false;
        }
    }
}