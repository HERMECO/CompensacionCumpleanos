﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hermeco.Compensacion.Cumpleanos.EmpleadosSAP {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetEmployeeSAPResponse", Namespace="http://schemas.datacontract.org/2004/07/EmpleadosSAP")]
    [System.SerializableAttribute()]
    public partial class GetEmployeeSAPResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.EmployeeSAP[] EmployeeSAPField;
        
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
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.EmployeeSAP[] EmployeeSAP {
            get {
                return this.EmployeeSAPField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeSAPField, value) != true)) {
                    this.EmployeeSAPField = value;
                    this.RaisePropertyChanged("EmployeeSAP");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeSAP", Namespace="http://schemas.datacontract.org/2004/07/EmpleadosSAP")]
    [System.SerializableAttribute()]
    public partial class EmployeeSAP : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Apellido1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Apellido2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CedulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CiudadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoDocumentoField;
        
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
        public string Apellido1 {
            get {
                return this.Apellido1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Apellido1Field, value) != true)) {
                    this.Apellido1Field = value;
                    this.RaisePropertyChanged("Apellido1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellido2 {
            get {
                return this.Apellido2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Apellido2Field, value) != true)) {
                    this.Apellido2Field = value;
                    this.RaisePropertyChanged("Apellido2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cedula {
            get {
                return this.CedulaField;
            }
            set {
                if ((object.ReferenceEquals(this.CedulaField, value) != true)) {
                    this.CedulaField = value;
                    this.RaisePropertyChanged("Cedula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ciudad {
            get {
                return this.CiudadField;
            }
            set {
                if ((object.ReferenceEquals(this.CiudadField, value) != true)) {
                    this.CiudadField = value;
                    this.RaisePropertyChanged("Ciudad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Depart {
            get {
                return this.DepartField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartField, value) != true)) {
                    this.DepartField = value;
                    this.RaisePropertyChanged("Depart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaField, value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre1 {
            get {
                return this.Nombre1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre1Field, value) != true)) {
                    this.Nombre1Field = value;
                    this.RaisePropertyChanged("Nombre1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre2 {
            get {
                return this.Nombre2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre2Field, value) != true)) {
                    this.Nombre2Field = value;
                    this.RaisePropertyChanged("Nombre2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pais {
            get {
                return this.PaisField;
            }
            set {
                if ((object.ReferenceEquals(this.PaisField, value) != true)) {
                    this.PaisField = value;
                    this.RaisePropertyChanged("Pais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDocumento {
            get {
                return this.TipoDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDocumentoField, value) != true)) {
                    this.TipoDocumentoField = value;
                    this.RaisePropertyChanged("TipoDocumento");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GetEmployeeIntranetResponse", Namespace="http://schemas.datacontract.org/2004/07/EmpleadosSAP")]
    [System.SerializableAttribute()]
    public partial class GetEmployeeIntranetResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.EmployeeIntranet[] EmployeeIntranetField;
        
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
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.EmployeeIntranet[] EmployeeIntranet {
            get {
                return this.EmployeeIntranetField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeIntranetField, value) != true)) {
                    this.EmployeeIntranetField = value;
                    this.RaisePropertyChanged("EmployeeIntranet");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeIntranet", Namespace="http://schemas.datacontract.org/2004/07/EmpleadosSAP")]
    [System.SerializableAttribute()]
    public partial class EmployeeIntranet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirthDayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CellPhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EMailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExtensionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HiringDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ManagerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelephoneField;
        
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
        public string Area {
            get {
                return this.AreaField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaField, value) != true)) {
                    this.AreaField = value;
                    this.RaisePropertyChanged("Area");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BirthDay {
            get {
                return this.BirthDayField;
            }
            set {
                if ((object.ReferenceEquals(this.BirthDayField, value) != true)) {
                    this.BirthDayField = value;
                    this.RaisePropertyChanged("BirthDay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CellPhone {
            get {
                return this.CellPhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.CellPhoneField, value) != true)) {
                    this.CellPhoneField = value;
                    this.RaisePropertyChanged("CellPhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EMail {
            get {
                return this.EMailField;
            }
            set {
                if ((object.ReferenceEquals(this.EMailField, value) != true)) {
                    this.EMailField = value;
                    this.RaisePropertyChanged("EMail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Extension {
            get {
                return this.ExtensionField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtensionField, value) != true)) {
                    this.ExtensionField = value;
                    this.RaisePropertyChanged("Extension");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HiringDate {
            get {
                return this.HiringDateField;
            }
            set {
                if ((object.ReferenceEquals(this.HiringDateField, value) != true)) {
                    this.HiringDateField = value;
                    this.RaisePropertyChanged("HiringDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdNo {
            get {
                return this.IdNoField;
            }
            set {
                if ((object.ReferenceEquals(this.IdNoField, value) != true)) {
                    this.IdNoField = value;
                    this.RaisePropertyChanged("IdNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoginName {
            get {
                return this.LoginNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginNameField, value) != true)) {
                    this.LoginNameField = value;
                    this.RaisePropertyChanged("LoginName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Manager {
            get {
                return this.ManagerField;
            }
            set {
                if ((object.ReferenceEquals(this.ManagerField, value) != true)) {
                    this.ManagerField = value;
                    this.RaisePropertyChanged("Manager");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Position {
            get {
                return this.PositionField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionField, value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telephone {
            get {
                return this.TelephoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephoneField, value) != true)) {
                    this.TelephoneField = value;
                    this.RaisePropertyChanged("Telephone");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmpleadosSAP.IEmpleadosSAPService")]
    public interface IEmpleadosSAPService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetEmpleadoSAP", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetEmpleadoSAPResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeSAPResponse GetEmpleadoSAP();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetEmpleadoSAP", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetEmpleadoSAPResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeSAPResponse> GetEmpleadoSAPAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesOfTheWeek", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesOfTheWeekResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetAnniversariesOfTheWeek();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesOfTheWeek", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesOfTheWeekResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetAnniversariesOfTheWeekAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetBirthdaysOfTheWeek", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetBirthdaysOfTheWeekResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetBirthdaysOfTheWeek();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetBirthdaysOfTheWeek", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetBirthdaysOfTheWeekResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetBirthdaysOfTheWeekAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesOfTheMonth", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesOfTheMonthResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetAnniversariesOfTheMonth();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesOfTheMonth", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesOfTheMonthResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetAnniversariesOfTheMonthAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetHiring", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetHiringResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetHiring();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetHiring", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetHiringResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetHiringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/SearchByCompleteName", ReplyAction="http://tempuri.org/IEmpleadosSAPService/SearchByCompleteNameResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse SearchByCompleteName(string strParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/SearchByCompleteName", ReplyAction="http://tempuri.org/IEmpleadosSAPService/SearchByCompleteNameResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> SearchByCompleteNameAsync(string strParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/SearchByIdNo", ReplyAction="http://tempuri.org/IEmpleadosSAPService/SearchByIdNoResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse SearchByIdNo(string strParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/SearchByIdNo", ReplyAction="http://tempuri.org/IEmpleadosSAPService/SearchByIdNoResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> SearchByIdNoAsync(string strParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetBirthdays", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetBirthdaysResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetBirthdays();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetBirthdays", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetBirthdaysResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetBirthdaysAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetAnniversaries", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetAnniversaries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetAnniversaries", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetAnniversariesResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetAnniversariesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetDatosEmpleados", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetDatosEmpleadosResponse")]
        Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetDatosEmpleados();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadosSAPService/GetDatosEmpleados", ReplyAction="http://tempuri.org/IEmpleadosSAPService/GetDatosEmpleadosResponse")]
        System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetDatosEmpleadosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpleadosSAPServiceChannel : Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.IEmpleadosSAPService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpleadosSAPServiceClient : System.ServiceModel.ClientBase<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.IEmpleadosSAPService>, Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.IEmpleadosSAPService {
        
        public EmpleadosSAPServiceClient() {
        }
        
        public EmpleadosSAPServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpleadosSAPServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpleadosSAPServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpleadosSAPServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeSAPResponse GetEmpleadoSAP() {
            return base.Channel.GetEmpleadoSAP();
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeSAPResponse> GetEmpleadoSAPAsync() {
            return base.Channel.GetEmpleadoSAPAsync();
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetAnniversariesOfTheWeek() {
            return base.Channel.GetAnniversariesOfTheWeek();
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetAnniversariesOfTheWeekAsync() {
            return base.Channel.GetAnniversariesOfTheWeekAsync();
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetBirthdaysOfTheWeek() {
            return base.Channel.GetBirthdaysOfTheWeek();
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetBirthdaysOfTheWeekAsync() {
            return base.Channel.GetBirthdaysOfTheWeekAsync();
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetAnniversariesOfTheMonth() {
            return base.Channel.GetAnniversariesOfTheMonth();
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetAnniversariesOfTheMonthAsync() {
            return base.Channel.GetAnniversariesOfTheMonthAsync();
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetHiring() {
            return base.Channel.GetHiring();
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetHiringAsync() {
            return base.Channel.GetHiringAsync();
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse SearchByCompleteName(string strParam) {
            return base.Channel.SearchByCompleteName(strParam);
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> SearchByCompleteNameAsync(string strParam) {
            return base.Channel.SearchByCompleteNameAsync(strParam);
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse SearchByIdNo(string strParam) {
            return base.Channel.SearchByIdNo(strParam);
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> SearchByIdNoAsync(string strParam) {
            return base.Channel.SearchByIdNoAsync(strParam);
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetBirthdays() {
            return base.Channel.GetBirthdays();
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetBirthdaysAsync() {
            return base.Channel.GetBirthdaysAsync();
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetAnniversaries() {
            return base.Channel.GetAnniversaries();
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetAnniversariesAsync() {
            return base.Channel.GetAnniversariesAsync();
        }
        
        public Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse GetDatosEmpleados() {
            return base.Channel.GetDatosEmpleados();
        }
        
        public System.Threading.Tasks.Task<Hermeco.Compensacion.Cumpleanos.EmpleadosSAP.GetEmployeeIntranetResponse> GetDatosEmpleadosAsync() {
            return base.Channel.GetDatosEmpleadosAsync();
        }
    }
}