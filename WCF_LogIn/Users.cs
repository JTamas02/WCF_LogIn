using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_LogIn
{
    [DataContract]
    public class Users
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string userName { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string fullname { get; set; }
        [DataMember]
        public int active { get; set; }
        [DataMember]
        public int rank { get; set; }
        [DataMember]
        public int ban { get; set; }
        [DataMember]
        public string ipadd { get; set; }
        [DataMember]
        public DateTime regtime { get; set; }
        [DataMember]
        public DateTime logtime { get; set; }
    }
}