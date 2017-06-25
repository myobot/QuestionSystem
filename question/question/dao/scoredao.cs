using System;
using System.Collections.Generic;
using System.Text;
using question.vo;
namespace question.dao
{
    class scoredao
    {
        public bool insertScore(score s)
        {
            string sql = "INSERT INTO score(username,tpid,score) VALUES('" + s.username + "','" + s.tpid + "','" + s.sc + "');";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql, null);
            if (i > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public List<score> getScoreList(String username)
        {
            List<score> s = new List<score>();
            string sql = "SELECT scoreid,tpid,score FROM score WHERE username='" + username + "';";
            MySql.Data.MySqlClient.MySqlDataReader dr = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql, null);
            while (dr.Read())
            {
                int scoreid = int.Parse(dr[0].ToString());
                int tpid = int.Parse(dr[1].ToString());
                int score = int.Parse(dr[2].ToString());
                score sc = new score();
                sc.sc = score;
                sc.scoreid = scoreid;
                sc.tpid = tpid;
                sc.username = username;
                s.Add(sc);
            }
            return s;
        }
    }
}
