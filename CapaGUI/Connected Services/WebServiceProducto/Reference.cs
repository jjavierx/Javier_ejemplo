﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.WebServiceProducto {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceProducto.WebServiceProductoSoap")]
    public interface WebServiceProductoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegisterProduct", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void RegisterProduct(CapaGUI.WebServiceProducto.ConsultaStock consultastock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegisterProduct", ReplyAction="*")]
        System.Threading.Tasks.Task RegisterProductAsync(CapaGUI.WebServiceProducto.ConsultaStock consultastock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegisterSalidaProduct", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void RegisterSalidaProduct(CapaGUI.WebServiceProducto.RegistraSalidaProducto RegistrarSalida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegisterSalidaProduct", ReplyAction="*")]
        System.Threading.Tasks.Task RegisterSalidaProductAsync(CapaGUI.WebServiceProducto.RegistraSalidaProducto RegistrarSalida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarStockService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarStockService(string sku);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarStockService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarStockServiceAsync(string sku);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarStockService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarStockService(CapaGUI.WebServiceProducto.ConsultaStock consultaStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarStockService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarStockServiceAsync(CapaGUI.WebServiceProducto.ConsultaStock consultaStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarProductoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaGUI.WebServiceProducto.ConsultaStock BuscarProductoService(string sku);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarProductoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.WebServiceProducto.ConsultaStock> BuscarProductoServiceAsync(string sku);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ConsultaStock : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string skuField;
        
        private int cantidadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Sku {
            get {
                return this.skuField;
            }
            set {
                this.skuField = value;
                this.RaisePropertyChanged("Sku");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
                this.RaisePropertyChanged("Cantidad");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistraSalidaProducto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int numero_salidaField;
        
        private System.DateTime fechaField;
        
        private int cantidad_salidaField;
        
        private string skuField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Numero_salida {
            get {
                return this.numero_salidaField;
            }
            set {
                this.numero_salidaField = value;
                this.RaisePropertyChanged("Numero_salida");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
                this.RaisePropertyChanged("Fecha");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Cantidad_salida {
            get {
                return this.cantidad_salidaField;
            }
            set {
                this.cantidad_salidaField = value;
                this.RaisePropertyChanged("Cantidad_salida");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Sku {
            get {
                return this.skuField;
            }
            set {
                this.skuField = value;
                this.RaisePropertyChanged("Sku");
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
    public interface WebServiceProductoSoapChannel : CapaGUI.WebServiceProducto.WebServiceProductoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceProductoSoapClient : System.ServiceModel.ClientBase<CapaGUI.WebServiceProducto.WebServiceProductoSoap>, CapaGUI.WebServiceProducto.WebServiceProductoSoap {
        
        public WebServiceProductoSoapClient() {
        }
        
        public WebServiceProductoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceProductoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceProductoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceProductoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void RegisterProduct(CapaGUI.WebServiceProducto.ConsultaStock consultastock) {
            base.Channel.RegisterProduct(consultastock);
        }
        
        public System.Threading.Tasks.Task RegisterProductAsync(CapaGUI.WebServiceProducto.ConsultaStock consultastock) {
            return base.Channel.RegisterProductAsync(consultastock);
        }
        
        public void RegisterSalidaProduct(CapaGUI.WebServiceProducto.RegistraSalidaProducto RegistrarSalida) {
            base.Channel.RegisterSalidaProduct(RegistrarSalida);
        }
        
        public System.Threading.Tasks.Task RegisterSalidaProductAsync(CapaGUI.WebServiceProducto.RegistraSalidaProducto RegistrarSalida) {
            return base.Channel.RegisterSalidaProductAsync(RegistrarSalida);
        }
        
        public System.Data.DataSet BuscarStockService(string sku) {
            return base.Channel.BuscarStockService(sku);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarStockServiceAsync(string sku) {
            return base.Channel.BuscarStockServiceAsync(sku);
        }
        
        public void actualizarStockService(CapaGUI.WebServiceProducto.ConsultaStock consultaStock) {
            base.Channel.actualizarStockService(consultaStock);
        }
        
        public System.Threading.Tasks.Task actualizarStockServiceAsync(CapaGUI.WebServiceProducto.ConsultaStock consultaStock) {
            return base.Channel.actualizarStockServiceAsync(consultaStock);
        }
        
        public CapaGUI.WebServiceProducto.ConsultaStock BuscarProductoService(string sku) {
            return base.Channel.BuscarProductoService(sku);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.WebServiceProducto.ConsultaStock> BuscarProductoServiceAsync(string sku) {
            return base.Channel.BuscarProductoServiceAsync(sku);
        }
    }
}
