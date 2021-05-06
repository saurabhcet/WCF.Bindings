using System;
using System.Runtime.Serialization;

namespace WCF.Model
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string UserName { get; set; }

    }
}
