using System;
using System.Collections.Generic;
using System.Text;

namespace question.dao
{
   
    class userdao
    {
        MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;
        private static string constr = "server=localhost;user id=root;password=wang8970;database=question;charset=utf8;";
        public bool findUser(String username,String password)
        {
            bool flag = false;
            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(constr);
            //define the command reference
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            //define the connection used by the command object
            msqlCommand.Connection = this.msqlConnection;
            //define the command text
            msqlCommand.CommandText = "SELECT username FROM user WHERE username='"+username+"' AND password='"+password+"';";
            Console.WriteLine(msqlCommand.CommandText);
            try
            {
                //open the connection
                this.msqlConnection.Open();
                //use a DataReader to process each record
                msqlCommand.ExecuteNonQuery();
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                if (msqlReader.HasRows)
                {
                    flag = true;
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
            return flag;
        }
        public bool addUser(user u)
        {
            
            string sql = "INSERT INTO user(username,password,sex,class,question,answer) VALUES('"+u.username+"','"+u.password+"','"+u.sex+"','"+u.Class+"','"+u.question+"','"+u.answer+"');";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql, null);
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
