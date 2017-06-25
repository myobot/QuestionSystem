using System;
using System.Collections.Generic;
using System.Text;
using question.vo;
namespace question.dao
{
    class historydao
    {
        public bool insterHistory(history h)
        {
            string sql = "INSERT INTO history(username,questionid,useranswer,rightorwrong,tpid) VALUES('" + h.username + "','" + h.questionid + "','" + h.useranswer + "','" + h.rightorwrong + "','" + h.tpid + "');";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql, null);
            if (i > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public List<history> getHistoryList(String username,int tpid)
        {
            List<history> lh = new List<history>();
            string sql = "SELECT historyid,questionid,rightorwrong,useranswer FROM history WHERE username='" + username + "' AND tpid='" + tpid + "';";
            MySql.Data.MySqlClient.MySqlDataReader dr = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql, null);
            while (dr.Read())
            {
                int historyid = int.Parse(dr[0].ToString());
                int questionid = int.Parse(dr[1].ToString());
                int rightorwrong = int.Parse(dr[2].ToString());
                String useranwer = dr[3].ToString();
                history h = new history();
                h.historyid = historyid;
                h.username = username;
                h.questionid = questionid;
                h.rightorwrong = rightorwrong;
                h.tpid = tpid;
                h.useranswer = useranwer;
                lh.Add(h);
            }
            return lh;
        }

    }
}
