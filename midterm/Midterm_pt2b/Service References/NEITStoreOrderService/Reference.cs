﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Midterm_pt2b.NEITStoreOrderService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="accountInfo", Namespace="http://schemas.datacontract.org/2004/07/Midterm_pt2a")]
    [System.SerializableAttribute()]
    public partial class accountInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Midterm_pt2b.NEITStoreOrderService.accounts[] AccountsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OwnerNameField;
        
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
        public string AccountId {
            get {
                return this.AccountIdField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountIdField, value) != true)) {
                    this.AccountIdField = value;
                    this.RaisePropertyChanged("AccountId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Midterm_pt2b.NEITStoreOrderService.accounts[] Accounts {
            get {
                return this.AccountsField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountsField, value) != true)) {
                    this.AccountsField = value;
                    this.RaisePropertyChanged("Accounts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OwnerName {
            get {
                return this.OwnerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerNameField, value) != true)) {
                    this.OwnerNameField = value;
                    this.RaisePropertyChanged("OwnerName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="accounts", Namespace="http://schemas.datacontract.org/2004/07/Midterm_pt2a")]
    [System.SerializableAttribute()]
    public partial class accounts : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Midterm_pt2b.NEITStoreOrderService.options OptionsField;
        
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
        public string AccountType {
            get {
                return this.AccountTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountTypeField, value) != true)) {
                    this.AccountTypeField = value;
                    this.RaisePropertyChanged("AccountType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Midterm_pt2b.NEITStoreOrderService.options Options {
            get {
                return this.OptionsField;
            }
            set {
                if ((object.ReferenceEquals(this.OptionsField, value) != true)) {
                    this.OptionsField = value;
                    this.RaisePropertyChanged("Options");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="options", Namespace="http://schemas.datacontract.org/2004/07/Midterm_pt2a")]
    [System.SerializableAttribute()]
    public partial class options : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FreeCheckingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OverDraftProtectionField;
        
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
        public string FreeChecking {
            get {
                return this.FreeCheckingField;
            }
            set {
                if ((object.ReferenceEquals(this.FreeCheckingField, value) != true)) {
                    this.FreeCheckingField = value;
                    this.RaisePropertyChanged("FreeChecking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OverDraftProtection {
            get {
                return this.OverDraftProtectionField;
            }
            set {
                if ((object.ReferenceEquals(this.OverDraftProtectionField, value) != true)) {
                    this.OverDraftProtectionField = value;
                    this.RaisePropertyChanged("OverDraftProtection");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NEITStoreOrderService.INEITStoreOrderService")]
    public interface INEITStoreOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrderService/ReturnAmountEarned", ReplyAction="http://tempuri.org/INEITStoreOrderService/ReturnAmountEarnedResponse")]
        double ReturnAmountEarned(double balance, double interest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrderService/ReturnAmountEarned", ReplyAction="http://tempuri.org/INEITStoreOrderService/ReturnAmountEarnedResponse")]
        System.Threading.Tasks.Task<double> ReturnAmountEarnedAsync(double balance, double interest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrderService/GetBankInformation", ReplyAction="http://tempuri.org/INEITStoreOrderService/GetBankInformationResponse")]
        Midterm_pt2b.NEITStoreOrderService.accountInfo GetBankInformation(string AccountID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrderService/GetBankInformation", ReplyAction="http://tempuri.org/INEITStoreOrderService/GetBankInformationResponse")]
        System.Threading.Tasks.Task<Midterm_pt2b.NEITStoreOrderService.accountInfo> GetBankInformationAsync(string AccountID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INEITStoreOrderServiceChannel : Midterm_pt2b.NEITStoreOrderService.INEITStoreOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NEITStoreOrderServiceClient : System.ServiceModel.ClientBase<Midterm_pt2b.NEITStoreOrderService.INEITStoreOrderService>, Midterm_pt2b.NEITStoreOrderService.INEITStoreOrderService {
        
        public NEITStoreOrderServiceClient() {
        }
        
        public NEITStoreOrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NEITStoreOrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NEITStoreOrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NEITStoreOrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ReturnAmountEarned(double balance, double interest) {
            return base.Channel.ReturnAmountEarned(balance, interest);
        }
        
        public System.Threading.Tasks.Task<double> ReturnAmountEarnedAsync(double balance, double interest) {
            return base.Channel.ReturnAmountEarnedAsync(balance, interest);
        }
        
        public Midterm_pt2b.NEITStoreOrderService.accountInfo GetBankInformation(string AccountID) {
            return base.Channel.GetBankInformation(AccountID);
        }
        
        public System.Threading.Tasks.Task<Midterm_pt2b.NEITStoreOrderService.accountInfo> GetBankInformationAsync(string AccountID) {
            return base.Channel.GetBankInformationAsync(AccountID);
        }
    }
}