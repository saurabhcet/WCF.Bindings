//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF.Client.ConcurrentRequest.SingleInstanceWithReentrantMode {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SingleInstanceWithReentrantMode.ISingleInstanceWithReentrantMode")]
    public interface ISingleInstanceWithReentrantMode {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISingleInstanceWithReentrantMode/Get", ReplyAction="http://tempuri.org/ISingleInstanceWithReentrantMode/GetResponse")]
        string Get(string client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISingleInstanceWithReentrantMode/Get", ReplyAction="http://tempuri.org/ISingleInstanceWithReentrantMode/GetResponse")]
        System.Threading.Tasks.Task<string> GetAsync(string client);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISingleInstanceWithReentrantModeChannel : WCF.Client.ConcurrentRequest.SingleInstanceWithReentrantMode.ISingleInstanceWithReentrantMode, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SingleInstanceWithReentrantModeClient : System.ServiceModel.ClientBase<WCF.Client.ConcurrentRequest.SingleInstanceWithReentrantMode.ISingleInstanceWithReentrantMode>, WCF.Client.ConcurrentRequest.SingleInstanceWithReentrantMode.ISingleInstanceWithReentrantMode {
        
        public SingleInstanceWithReentrantModeClient() {
        }
        
        public SingleInstanceWithReentrantModeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SingleInstanceWithReentrantModeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SingleInstanceWithReentrantModeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SingleInstanceWithReentrantModeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Get(string client) {
            return base.Channel.Get(client);
        }
        
        public System.Threading.Tasks.Task<string> GetAsync(string client) {
            return base.Channel.GetAsync(client);
        }
    }
}
