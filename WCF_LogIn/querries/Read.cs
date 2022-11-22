using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WCF_LogIn.querries
{
    public class Read
    {
        public bool Auth(string name, string pwd)
        {
            Connect c = new Connect();
            try
            {
                string qry = "SELECT id FROM users uname=@uname AND pwd=@pwd;";
                MySqlCommand cmd = new MySqlCommand(qry);
                cmd.Connection = c.connect;
                cmd.Parameters.AddWithValue("@uname", name);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.CommandText = qry;
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}