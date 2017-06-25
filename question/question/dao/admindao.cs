using System;
using System.Collections.Generic;
using System.Text;
namespace question.dao
{
    class admindao
    {
        MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;
        private static string constr = "server=localhost;user id=root;password=wang8970;database=question;charset=utf8;";
        public bool findadmin(String adminname,String password)
        {
            bool flag = false;
            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(constr);
            //define the command reference
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            //define the connection used by the command object
            msqlCommand.Connection = this.msqlConnection;
            //define the command text
            msqlCommand.CommandText = "SELECT adminname FROM admin WHERE adminname='" + adminname + "' AND password='" + password + "';";
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
        public bool addadmin(admin a)
        {
            bool flag = false;
            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(constr);
            //define the command reference
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
            //define the connection used by the command object
            msqlCommand.Connection = this.msqlConnection;
            //define the command text
            msqlCommand.CommandText = "INSERT INTO admin(adminname,password) VALUES('" + a.adminname+ "','" + a.password + "');";
            Console.WriteLine(msqlCommand.CommandText);
            try
            {
                //open the connection
                this.msqlConnection.Open();
                //use a DataReader to process each record
                int i = msqlCommand.ExecuteNonQuery();
                if (i > 0)
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
    }
}
