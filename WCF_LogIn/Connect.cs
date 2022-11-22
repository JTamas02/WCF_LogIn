using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WCF_LogIn
{
    internal class Connect
    {
        public MySqlConnection connect;

        private string server;
        private string username;
        private string password;
        private string database;
        private string connectionstring;
        public Connect()
        {
            server = "127.0.0.1";
            username = "root";
            password = "";
            database = "backanddb";

            connectionstring += "Server=" + server + "; DATABASE=" + database + "; UID=" + username + "; PASSWORD=" + password + ";" + "SslMode=None";
            connect = new MySqlConnection(connectionstring);
            try
            {
                connect.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}