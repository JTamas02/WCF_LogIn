using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;
using WCF_LogIn.querries;

namespace WCF_LogIn
{

    public class Service1 : IService1
    { 
        public string regCheck(Users user)
        {
            Read r = new Read();
            if (r.Auth(user.userName, user.password))
            {
                return "A felhasználó regisztrált tag";
            }
            else
            {
                return "A felhasználó még nem regisztrált tag";
            }
        }
    }
}
