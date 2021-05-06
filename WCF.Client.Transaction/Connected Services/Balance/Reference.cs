﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF.Client.Transaction.Balance {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WCF.Model")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserAccount", Namespace="http://schemas.datacontract.org/2004/07/WCF.Model")]
    [System.SerializableAttribute()]
    public partial class UserAccount : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Balance.IBalance")]
    public interface IBalance {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalance/Debit", ReplyAction="http://tempuri.org/IBalance/DebitResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        WCF.Client.Transaction.Balance.UserAccount Debit(WCF.Client.Transaction.Balance.User user, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalance/Debit", ReplyAction="http://tempuri.org/IBalance/DebitResponse")]
        System.Threading.Tasks.Task<WCF.Client.Transaction.Balance.UserAccount> DebitAsync(WCF.Client.Transaction.Balance.User user, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalance/Credit", ReplyAction="http://tempuri.org/IBalance/CreditResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        WCF.Client.Transaction.Balance.UserAccount Credit(WCF.Client.Transaction.Balance.User user, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalance/Credit", ReplyAction="http://tempuri.org/IBalance/CreditResponse")]
        System.Threading.Tasks.Task<WCF.Client.Transaction.Balance.UserAccount> CreditAsync(WCF.Client.Transaction.Balance.User user, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalance/AccountDetails", ReplyAction="http://tempuri.org/IBalance/AccountDetailsResponse")]
        WCF.Client.Transaction.Balance.UserAccount AccountDetails(WCF.Client.Transaction.Balance.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBalance/AccountDetails", ReplyAction="http://tempuri.org/IBalance/AccountDetailsResponse")]
        System.Threading.Tasks.Task<WCF.Client.Transaction.Balance.UserAccount> AccountDetailsAsync(WCF.Client.Transaction.Balance.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBalanceChannel : WCF.Client.Transaction.Balance.IBalance, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BalanceClient : System.ServiceModel.ClientBase<WCF.Client.Transaction.Balance.IBalance>, WCF.Client.Transaction.Balance.IBalance {
        
        public BalanceClient() {
        }
        
        public BalanceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BalanceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BalanceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BalanceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCF.Client.Transaction.Balance.UserAccount Debit(WCF.Client.Transaction.Balance.User user, int amount) {
            return base.Channel.Debit(user, amount);
        }
        
        public System.Threading.Tasks.Task<WCF.Client.Transaction.Balance.UserAccount> DebitAsync(WCF.Client.Transaction.Balance.User user, int amount) {
            return base.Channel.DebitAsync(user, amount);
        }
        
        public WCF.Client.Transaction.Balance.UserAccount Credit(WCF.Client.Transaction.Balance.User user, int amount) {
            return base.Channel.Credit(user, amount);
        }
        
        public System.Threading.Tasks.Task<WCF.Client.Transaction.Balance.UserAccount> CreditAsync(WCF.Client.Transaction.Balance.User user, int amount) {
            return base.Channel.CreditAsync(user, amount);
        }
        
        public WCF.Client.Transaction.Balance.UserAccount AccountDetails(WCF.Client.Transaction.Balance.User user) {
            return base.Channel.AccountDetails(user);
        }
        
        public System.Threading.Tasks.Task<WCF.Client.Transaction.Balance.UserAccount> AccountDetailsAsync(WCF.Client.Transaction.Balance.User user) {
            return base.Channel.AccountDetailsAsync(user);
        }
    }
}
