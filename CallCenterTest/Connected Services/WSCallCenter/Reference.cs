﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CallCenterTest.WSCallCenter {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WcfCallCenter")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaPagoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float montoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreCompletoField;
        
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
        public System.DateTime FechaPago {
            get {
                return this.FechaPagoField;
            }
            set {
                if ((this.FechaPagoField.Equals(value) != true)) {
                    this.FechaPagoField = value;
                    this.RaisePropertyChanged("FechaPago");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float monto {
            get {
                return this.montoField;
            }
            set {
                if ((this.montoField.Equals(value) != true)) {
                    this.montoField = value;
                    this.RaisePropertyChanged("monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreCompleto {
            get {
                return this.nombreCompletoField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreCompletoField, value) != true)) {
                    this.nombreCompletoField = value;
                    this.RaisePropertyChanged("nombreCompleto");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSCallCenter.ISCallCenter")]
    public interface ISCallCenter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISCallCenter/ConsultaPagosCliente", ReplyAction="http://tempuri.org/ISCallCenter/ConsultaPagosClienteResponse")]
        CallCenterTest.WSCallCenter.Cliente[] ConsultaPagosCliente(string clienteCedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISCallCenter/ConsultaPagosCliente", ReplyAction="http://tempuri.org/ISCallCenter/ConsultaPagosClienteResponse")]
        System.Threading.Tasks.Task<CallCenterTest.WSCallCenter.Cliente[]> ConsultaPagosClienteAsync(string clienteCedula);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISCallCenterChannel : CallCenterTest.WSCallCenter.ISCallCenter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SCallCenterClient : System.ServiceModel.ClientBase<CallCenterTest.WSCallCenter.ISCallCenter>, CallCenterTest.WSCallCenter.ISCallCenter {
        
        public SCallCenterClient() {
        }
        
        public SCallCenterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SCallCenterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SCallCenterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SCallCenterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CallCenterTest.WSCallCenter.Cliente[] ConsultaPagosCliente(string clienteCedula) {
            return base.Channel.ConsultaPagosCliente(clienteCedula);
        }
        
        public System.Threading.Tasks.Task<CallCenterTest.WSCallCenter.Cliente[]> ConsultaPagosClienteAsync(string clienteCedula) {
            return base.Channel.ConsultaPagosClienteAsync(clienteCedula);
        }
    }
}
