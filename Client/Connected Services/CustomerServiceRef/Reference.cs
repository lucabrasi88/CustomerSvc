﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CustomerServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/CustomerSvc.Core")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerNumber {
            get {
                return this.CustomerNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerNumberField, value) != true)) {
                    this.CustomerNumberField = value;
                    this.RaisePropertyChanged("CustomerNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerServiceRef.ICustomerService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        void AddCustomer(Client.CustomerServiceRef.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(Client.CustomerServiceRef.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        void UpdateCustomer(Client.CustomerServiceRef.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        System.Threading.Tasks.Task UpdateCustomerAsync(Client.CustomerServiceRef.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        void DeleteCustomer(int customerNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(int customerNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetAll", ReplyAction="http://tempuri.org/ICustomerService/GetAllResponse")]
        Client.CustomerServiceRef.Customer[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetAll", ReplyAction="http://tempuri.org/ICustomerService/GetAllResponse")]
        System.Threading.Tasks.Task<Client.CustomerServiceRef.Customer[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/FindByCustomerNumber", ReplyAction="http://tempuri.org/ICustomerService/FindByCustomerNumberResponse")]
        Client.CustomerServiceRef.Customer FindByCustomerNumber(string customerNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/FindByCustomerNumber", ReplyAction="http://tempuri.org/ICustomerService/FindByCustomerNumberResponse")]
        System.Threading.Tasks.Task<Client.CustomerServiceRef.Customer> FindByCustomerNumberAsync(string customerNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : Client.CustomerServiceRef.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<Client.CustomerServiceRef.ICustomerService>, Client.CustomerServiceRef.ICustomerService {
        
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
        
        public void AddCustomer(Client.CustomerServiceRef.Customer customer) {
            base.Channel.AddCustomer(customer);
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(Client.CustomerServiceRef.Customer customer) {
            return base.Channel.AddCustomerAsync(customer);
        }
        
        public void UpdateCustomer(Client.CustomerServiceRef.Customer customer) {
            base.Channel.UpdateCustomer(customer);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerAsync(Client.CustomerServiceRef.Customer customer) {
            return base.Channel.UpdateCustomerAsync(customer);
        }
        
        public void DeleteCustomer(int customerNumber) {
            base.Channel.DeleteCustomer(customerNumber);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(int customerNumber) {
            return base.Channel.DeleteCustomerAsync(customerNumber);
        }
        
        public Client.CustomerServiceRef.Customer[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Client.CustomerServiceRef.Customer[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public Client.CustomerServiceRef.Customer FindByCustomerNumber(string customerNumber) {
            return base.Channel.FindByCustomerNumber(customerNumber);
        }
        
        public System.Threading.Tasks.Task<Client.CustomerServiceRef.Customer> FindByCustomerNumberAsync(string customerNumber) {
            return base.Channel.FindByCustomerNumberAsync(customerNumber);
        }
    }
}
