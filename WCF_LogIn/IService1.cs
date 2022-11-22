using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_LogIn
{
   
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "*",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "regCheck")]

        string regCheck(Users user);
    }
}
