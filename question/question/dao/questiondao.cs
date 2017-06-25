using System;
using System.Collections.Generic;
using System.Text;
using question.vo;
using System.Data;
namespace question.dao
{
    class questiondao
    {
        MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;
        private static string constr = "server=localhost;user id=root;password=wang8970;database=question;charset=utf8;";
        public List<Question> getQuestionList()
        {
            List<Question> q = new List<Question>();
            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(constr);
            //define the command reference
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            //define the connection used by the command object
            msqlCommand.Connection = this.msqlConnection;
            //define the command text
            msqlCommand.CommandText = "SELECT questionid,q_name,c_a,c_b,c_c,c_d,hardlevel,score,answer FROM question ;";

            Console.WriteLine(msqlCommand.CommandText);
            try
            {
                //open the connection
                this.msqlConnection.Open();
                //use a DataReader to process each record
                msqlCommand.ExecuteNonQuery();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(msqlReader);
                int C = dt.Rows.Count;
                Random r = new Random(Guid.NewGuid().GetHashCode());
                bool[] Bquestion = new bool[C];
                int j = 0;
                for (int i = 0; i < 100000; i++)
                {
                    int rc = r.Next(C);
                    if (Bquestion[rc] == false)
                    {
                        Question qu = new Question();
                        qu.questionid = int.Parse(dt.Rows[rc]["questionid"].ToString());
                        qu.q_name = dt.Rows[rc]["q_name"].ToString();
                        qu.c_a = dt.Rows[rc]["c_a"].ToString();
                        qu.c_b = dt.Rows[rc]["c_b"].ToString();
                        qu.c_c = dt.Rows[rc]["c_c"].ToString();
                        qu.c_d = dt.Rows[rc]["c_d"].ToString();
                        qu.hardlevel = int.Parse(dt.Rows[rc]["hardlevel"].ToString());
                        qu.score = int.Parse(dt.Rows[rc]["score"].ToString());
                        qu.answer = dt.Rows[rc]["answer"].ToString();
                        q.Add(qu);
                        j++;
                    }
                    if (j == 10)
                    {
                        break;
                    }
                }
            }
            catch (Exception er)
            {
                //do something with the exception
            }
            finally
            {
                //always close the connection
                this.msqlConnection.Close();
            }
            return q;
        }
        public bool insertQuestion(Question q)
        {
            string sql = "INSERT INTO question(q_name,c_a,c_b,c_c,c_d,hardlevel,score,answer) VALUES('" + q.q_name + "','" + q.c_a + "','" + q.c_b + "','" + q.c_c + "','" + q.c_d + "','" + q.hardlevel + "','" + q.score + "','" + q.answer + "');";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sql, null);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateQuetion(Question q)
        {
            string sql = "UPDATE question SET q_name='" + q.score + "',c_a='" + q.c_a + "',c_b='" + q.c_b + "',c_c='" + q.c_c + "',c_d='" + q.c_d + "',hardlevel='" + q.hardlevel + "',score='" + q.score + "',answer='" + q.answer + "' WHERE questionid='" + q.questionid + "';";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sql, null);
            if (i > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public bool DeleteQuestion(int questionid)
        {
            string sql = "DELETE FROM question WHERE questionid='" + questionid + "';";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sql, null);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Question getQuestion(int questionid)
        {
            Question q = null;
            string sql = "SELECT q_name,c_a,c_b,c_c,c_d,hardlevel,score,answer FROM question WHERE questionid='" + questionid + "';";
            MySql.Data.MySqlClient.MySqlDataReader dr = MySqlHelper.ExecuteReader(MySqlHelper.Conn, CommandType.Text, sql, null);
            if (dr.Read())
            {
                q = new Question();
                q.questionid = questionid;
                q.q_name = dr[0].ToString();
                q.c_a = dr[1].ToString();
                q.c_b = dr[2].ToString();
                q.c_c = dr[3].ToString();
                q.c_d = dr[4].ToString();
                q.hardlevel = int.Parse(dr[5].ToString());
                q.score = int.Parse(dr[6].ToString());
                q.answer = dr[7].ToString();
            }
            return q;
        }
    }
}
