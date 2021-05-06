using System;
using System.Runtime.Serialization;

namespace WCF.Model
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public Guid TransactionNumber { get; set; }

        [DataMember]
        public int EMIAmount { get; set; }

        [DataMember]
        public bool PaymentStatus { get; set; }
    }
}