﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WC_SOAP_DWF.Products {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.udb.edu.sv/api/generated", ConfigurationName="Products.productPort")]
    public interface productPort {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación deleteProduct no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WC_SOAP_DWF.Products.deleteProductResponse1 deleteProduct(WC_SOAP_DWF.Products.deleteProductRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.deleteProductResponse1> deleteProductAsync(WC_SOAP_DWF.Products.deleteProductRequest1 request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación addProduct no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WC_SOAP_DWF.Products.addProductResponse1 addProduct(WC_SOAP_DWF.Products.addProductRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.addProductResponse1> addProductAsync(WC_SOAP_DWF.Products.addProductRequest1 request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación getProductById no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WC_SOAP_DWF.Products.getProductByIdResponse1 getProductById(WC_SOAP_DWF.Products.getProductByIdRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.getProductByIdResponse1> getProductByIdAsync(WC_SOAP_DWF.Products.getProductByIdRequest1 request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación updateProduct no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WC_SOAP_DWF.Products.updateProductResponse1 updateProduct(WC_SOAP_DWF.Products.updateProductRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.updateProductResponse1> updateProductAsync(WC_SOAP_DWF.Products.updateProductRequest1 request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación getAllProducts no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WC_SOAP_DWF.Products.getAllProductsResponse getAllProducts(WC_SOAP_DWF.Products.getAllProductsRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.getAllProductsResponse> getAllProductsAsync(WC_SOAP_DWF.Products.getAllProductsRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class deleteProductRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class productInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nameField;
        
        private double priceField;
        
        private string categoryField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public double price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
                this.RaisePropertyChanged("price");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
                this.RaisePropertyChanged("category");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class processStatus : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string statusCodeField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string StatusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("StatusCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class deleteProductResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private processStatus processStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public processStatus processStatus {
            get {
                return this.processStatusField;
            }
            set {
                this.processStatusField = value;
                this.RaisePropertyChanged("processStatus");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteProductRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        public WC_SOAP_DWF.Products.deleteProductRequest deleteProductRequest;
        
        public deleteProductRequest1() {
        }
        
        public deleteProductRequest1(WC_SOAP_DWF.Products.deleteProductRequest deleteProductRequest) {
            this.deleteProductRequest = deleteProductRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteProductResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        public WC_SOAP_DWF.Products.deleteProductResponse deleteProductResponse;
        
        public deleteProductResponse1() {
        }
        
        public deleteProductResponse1(WC_SOAP_DWF.Products.deleteProductResponse deleteProductResponse) {
            this.deleteProductResponse = deleteProductResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class addProductRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private double priceField;
        
        private string categoryField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
                this.RaisePropertyChanged("price");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
                this.RaisePropertyChanged("category");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class addProductResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private processStatus processStatusField;
        
        private productInfo productField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public processStatus processStatus {
            get {
                return this.processStatusField;
            }
            set {
                this.processStatusField = value;
                this.RaisePropertyChanged("processStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public productInfo product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
                this.RaisePropertyChanged("product");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addProductRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        public WC_SOAP_DWF.Products.addProductRequest addProductRequest;
        
        public addProductRequest1() {
        }
        
        public addProductRequest1(WC_SOAP_DWF.Products.addProductRequest addProductRequest) {
            this.addProductRequest = addProductRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addProductResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        public WC_SOAP_DWF.Products.addProductResponse addProductResponse;
        
        public addProductResponse1() {
        }
        
        public addProductResponse1(WC_SOAP_DWF.Products.addProductResponse addProductResponse) {
            this.addProductResponse = addProductResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class getProductByIdRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class getProductByIdResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private productInfo productField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public productInfo Product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
                this.RaisePropertyChanged("Product");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getProductByIdRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        public WC_SOAP_DWF.Products.getProductByIdRequest getProductByIdRequest;
        
        public getProductByIdRequest1() {
        }
        
        public getProductByIdRequest1(WC_SOAP_DWF.Products.getProductByIdRequest getProductByIdRequest) {
            this.getProductByIdRequest = getProductByIdRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getProductByIdResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        public WC_SOAP_DWF.Products.getProductByIdResponse getProductByIdResponse;
        
        public getProductByIdResponse1() {
        }
        
        public getProductByIdResponse1(WC_SOAP_DWF.Products.getProductByIdResponse getProductByIdResponse) {
            this.getProductByIdResponse = getProductByIdResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class updateProductRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private productInfo productField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public productInfo product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
                this.RaisePropertyChanged("product");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class updateProductResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private processStatus processStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public processStatus processStatus {
            get {
                return this.processStatusField;
            }
            set {
                this.processStatusField = value;
                this.RaisePropertyChanged("processStatus");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateProductRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        public WC_SOAP_DWF.Products.updateProductRequest updateProductRequest;
        
        public updateProductRequest1() {
        }
        
        public updateProductRequest1(WC_SOAP_DWF.Products.updateProductRequest updateProductRequest) {
            this.updateProductRequest = updateProductRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateProductResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        public WC_SOAP_DWF.Products.updateProductResponse updateProductResponse;
        
        public updateProductResponse1() {
        }
        
        public updateProductResponse1(WC_SOAP_DWF.Products.updateProductResponse updateProductResponse) {
            this.updateProductResponse = updateProductResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.udb.edu.sv/api/generated")]
    public partial class getAllProductsRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getAllProductsRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        public WC_SOAP_DWF.Products.getAllProductsRequest getAllProductsRequest;
        
        public getAllProductsRequest1() {
        }
        
        public getAllProductsRequest1(WC_SOAP_DWF.Products.getAllProductsRequest getAllProductsRequest) {
            this.getAllProductsRequest = getAllProductsRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getAllProductsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getAllProductsResponse", Namespace="http://www.udb.edu.sv/api/generated", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("products", IsNullable=false)]
        public WC_SOAP_DWF.Products.productInfo[] getAllProductsResponse1;
        
        public getAllProductsResponse() {
        }
        
        public getAllProductsResponse(WC_SOAP_DWF.Products.productInfo[] getAllProductsResponse1) {
            this.getAllProductsResponse1 = getAllProductsResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface productPortChannel : WC_SOAP_DWF.Products.productPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class productPortClient : System.ServiceModel.ClientBase<WC_SOAP_DWF.Products.productPort>, WC_SOAP_DWF.Products.productPort {
        
        public productPortClient() {
        }
        
        public productPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public productPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public productPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public productPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WC_SOAP_DWF.Products.deleteProductResponse1 WC_SOAP_DWF.Products.productPort.deleteProduct(WC_SOAP_DWF.Products.deleteProductRequest1 request) {
            return base.Channel.deleteProduct(request);
        }
        
        public WC_SOAP_DWF.Products.deleteProductResponse deleteProduct(WC_SOAP_DWF.Products.deleteProductRequest deleteProductRequest) {
            WC_SOAP_DWF.Products.deleteProductRequest1 inValue = new WC_SOAP_DWF.Products.deleteProductRequest1();
            inValue.deleteProductRequest = deleteProductRequest;
            WC_SOAP_DWF.Products.deleteProductResponse1 retVal = ((WC_SOAP_DWF.Products.productPort)(this)).deleteProduct(inValue);
            return retVal.deleteProductResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.deleteProductResponse1> WC_SOAP_DWF.Products.productPort.deleteProductAsync(WC_SOAP_DWF.Products.deleteProductRequest1 request) {
            return base.Channel.deleteProductAsync(request);
        }
        
        public System.Threading.Tasks.Task<WC_SOAP_DWF.Products.deleteProductResponse1> deleteProductAsync(WC_SOAP_DWF.Products.deleteProductRequest deleteProductRequest) {
            WC_SOAP_DWF.Products.deleteProductRequest1 inValue = new WC_SOAP_DWF.Products.deleteProductRequest1();
            inValue.deleteProductRequest = deleteProductRequest;
            return ((WC_SOAP_DWF.Products.productPort)(this)).deleteProductAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WC_SOAP_DWF.Products.addProductResponse1 WC_SOAP_DWF.Products.productPort.addProduct(WC_SOAP_DWF.Products.addProductRequest1 request) {
            return base.Channel.addProduct(request);
        }
        
        public WC_SOAP_DWF.Products.addProductResponse addProduct(WC_SOAP_DWF.Products.addProductRequest addProductRequest) {
            WC_SOAP_DWF.Products.addProductRequest1 inValue = new WC_SOAP_DWF.Products.addProductRequest1();
            inValue.addProductRequest = addProductRequest;
            WC_SOAP_DWF.Products.addProductResponse1 retVal = ((WC_SOAP_DWF.Products.productPort)(this)).addProduct(inValue);
            return retVal.addProductResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.addProductResponse1> WC_SOAP_DWF.Products.productPort.addProductAsync(WC_SOAP_DWF.Products.addProductRequest1 request) {
            return base.Channel.addProductAsync(request);
        }
        
        public System.Threading.Tasks.Task<WC_SOAP_DWF.Products.addProductResponse1> addProductAsync(WC_SOAP_DWF.Products.addProductRequest addProductRequest) {
            WC_SOAP_DWF.Products.addProductRequest1 inValue = new WC_SOAP_DWF.Products.addProductRequest1();
            inValue.addProductRequest = addProductRequest;
            return ((WC_SOAP_DWF.Products.productPort)(this)).addProductAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WC_SOAP_DWF.Products.getProductByIdResponse1 WC_SOAP_DWF.Products.productPort.getProductById(WC_SOAP_DWF.Products.getProductByIdRequest1 request) {
            return base.Channel.getProductById(request);
        }
        
        public WC_SOAP_DWF.Products.getProductByIdResponse getProductById(WC_SOAP_DWF.Products.getProductByIdRequest getProductByIdRequest) {
            WC_SOAP_DWF.Products.getProductByIdRequest1 inValue = new WC_SOAP_DWF.Products.getProductByIdRequest1();
            inValue.getProductByIdRequest = getProductByIdRequest;
            WC_SOAP_DWF.Products.getProductByIdResponse1 retVal = ((WC_SOAP_DWF.Products.productPort)(this)).getProductById(inValue);
            return retVal.getProductByIdResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.getProductByIdResponse1> WC_SOAP_DWF.Products.productPort.getProductByIdAsync(WC_SOAP_DWF.Products.getProductByIdRequest1 request) {
            return base.Channel.getProductByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<WC_SOAP_DWF.Products.getProductByIdResponse1> getProductByIdAsync(WC_SOAP_DWF.Products.getProductByIdRequest getProductByIdRequest) {
            WC_SOAP_DWF.Products.getProductByIdRequest1 inValue = new WC_SOAP_DWF.Products.getProductByIdRequest1();
            inValue.getProductByIdRequest = getProductByIdRequest;
            return ((WC_SOAP_DWF.Products.productPort)(this)).getProductByIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WC_SOAP_DWF.Products.updateProductResponse1 WC_SOAP_DWF.Products.productPort.updateProduct(WC_SOAP_DWF.Products.updateProductRequest1 request) {
            return base.Channel.updateProduct(request);
        }
        
        public WC_SOAP_DWF.Products.updateProductResponse updateProduct(WC_SOAP_DWF.Products.updateProductRequest updateProductRequest) {
            WC_SOAP_DWF.Products.updateProductRequest1 inValue = new WC_SOAP_DWF.Products.updateProductRequest1();
            inValue.updateProductRequest = updateProductRequest;
            WC_SOAP_DWF.Products.updateProductResponse1 retVal = ((WC_SOAP_DWF.Products.productPort)(this)).updateProduct(inValue);
            return retVal.updateProductResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.updateProductResponse1> WC_SOAP_DWF.Products.productPort.updateProductAsync(WC_SOAP_DWF.Products.updateProductRequest1 request) {
            return base.Channel.updateProductAsync(request);
        }
        
        public System.Threading.Tasks.Task<WC_SOAP_DWF.Products.updateProductResponse1> updateProductAsync(WC_SOAP_DWF.Products.updateProductRequest updateProductRequest) {
            WC_SOAP_DWF.Products.updateProductRequest1 inValue = new WC_SOAP_DWF.Products.updateProductRequest1();
            inValue.updateProductRequest = updateProductRequest;
            return ((WC_SOAP_DWF.Products.productPort)(this)).updateProductAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WC_SOAP_DWF.Products.getAllProductsResponse WC_SOAP_DWF.Products.productPort.getAllProducts(WC_SOAP_DWF.Products.getAllProductsRequest1 request) {
            return base.Channel.getAllProducts(request);
        }
        
        public WC_SOAP_DWF.Products.productInfo[] getAllProducts(WC_SOAP_DWF.Products.getAllProductsRequest getAllProductsRequest) {
            WC_SOAP_DWF.Products.getAllProductsRequest1 inValue = new WC_SOAP_DWF.Products.getAllProductsRequest1();
            inValue.getAllProductsRequest = getAllProductsRequest;
            WC_SOAP_DWF.Products.getAllProductsResponse retVal = ((WC_SOAP_DWF.Products.productPort)(this)).getAllProducts(inValue);
            return retVal.getAllProductsResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WC_SOAP_DWF.Products.getAllProductsResponse> WC_SOAP_DWF.Products.productPort.getAllProductsAsync(WC_SOAP_DWF.Products.getAllProductsRequest1 request) {
            return base.Channel.getAllProductsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WC_SOAP_DWF.Products.getAllProductsResponse> getAllProductsAsync(WC_SOAP_DWF.Products.getAllProductsRequest getAllProductsRequest) {
            WC_SOAP_DWF.Products.getAllProductsRequest1 inValue = new WC_SOAP_DWF.Products.getAllProductsRequest1();
            inValue.getAllProductsRequest = getAllProductsRequest;
            return ((WC_SOAP_DWF.Products.productPort)(this)).getAllProductsAsync(inValue);
        }
    }
}