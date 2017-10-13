﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerGUI.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/CreateComCustomer", ReplyAction="http://tempuri.org/ICustomerService/CreateComCustomerResponse")]
        Model.Customer CreateComCustomer(string name, string phone, string address, string zip, string accountNo, string cvr, string ean);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/CreateComCustomer", ReplyAction="http://tempuri.org/ICustomerService/CreateComCustomerResponse")]
        System.Threading.Tasks.Task<Model.Customer> CreateComCustomerAsync(string name, string phone, string address, string zip, string accountNo, string cvr, string ean);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/CreatePrivCustomer", ReplyAction="http://tempuri.org/ICustomerService/CreatePrivCustomerResponse")]
        Model.Customer CreatePrivCustomer(string name, string phone, string address, string zip, string accountNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/CreatePrivCustomer", ReplyAction="http://tempuri.org/ICustomerService/CreatePrivCustomerResponse")]
        System.Threading.Tasks.Task<Model.Customer> CreatePrivCustomerAsync(string name, string phone, string address, string zip, string accountNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        void UpdateCustomer(string name, string phone, string CustomerNo, string Zip, string AccountNo, string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        System.Threading.Tasks.Task UpdateCustomerAsync(string name, string phone, string CustomerNo, string Zip, string AccountNo, string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        void DeleteCustomer(Model.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(Model.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : CustomerGUI.ServiceReference.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<CustomerGUI.ServiceReference.ICustomerService>, CustomerGUI.ServiceReference.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Model.Customer CreateComCustomer(string name, string phone, string address, string zip, string accountNo, string cvr, string ean) {
            return base.Channel.CreateComCustomer(name, phone, address, zip, accountNo, cvr, ean);
        }
        
        public System.Threading.Tasks.Task<Model.Customer> CreateComCustomerAsync(string name, string phone, string address, string zip, string accountNo, string cvr, string ean) {
            return base.Channel.CreateComCustomerAsync(name, phone, address, zip, accountNo, cvr, ean);
        }
        
        public Model.Customer CreatePrivCustomer(string name, string phone, string address, string zip, string accountNo) {
            return base.Channel.CreatePrivCustomer(name, phone, address, zip, accountNo);
        }
        
        public System.Threading.Tasks.Task<Model.Customer> CreatePrivCustomerAsync(string name, string phone, string address, string zip, string accountNo) {
            return base.Channel.CreatePrivCustomerAsync(name, phone, address, zip, accountNo);
        }
        
        public void UpdateCustomer(string name, string phone, string CustomerNo, string Zip, string AccountNo, string address) {
            base.Channel.UpdateCustomer(name, phone, CustomerNo, Zip, AccountNo, address);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerAsync(string name, string phone, string CustomerNo, string Zip, string AccountNo, string address) {
            return base.Channel.UpdateCustomerAsync(name, phone, CustomerNo, Zip, AccountNo, address);
        }
        
        public void DeleteCustomer(Model.Customer customer) {
            base.Channel.DeleteCustomer(customer);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(Model.Customer customer) {
            return base.Channel.DeleteCustomerAsync(customer);
        }
    }
}
