using System;
using System.Runtime.Serialization;

namespace WCF.Model
{
    [DataContract]
    public class UserAccount
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int Balance { get; set; }

    }
}
