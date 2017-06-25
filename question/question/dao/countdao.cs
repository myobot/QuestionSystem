using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace question.dao
{
    class countdao
    {
        public int getTpCount()
        {
            MySqlDataReader m = MySqlHelper.ExecuteReader(MySqlHelper.Conn, CommandType.Text, "Select count from tpcount WHERE countid=1",null);
            m.Read();
            return int.Parse(m[0].ToString());
        }
        public bool updateCount(int count)
        {
            string sql = "UPDATE tpcount SET count='" + count + "' WHERE countid=1";
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
    }
}
