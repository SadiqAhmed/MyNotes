﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNotes.UI.Web.AdminServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GroupDto", Namespace="http://schemas.datacontract.org/2004/07/MyNotes.Backend.Dtos")]
    [System.SerializableAttribute()]
    public partial class GroupDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSystemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.Guid Id {
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
        public bool IsSystem {
            get {
                return this.IsSystemField;
            }
            set {
                if ((this.IsSystemField.Equals(value) != true)) {
                    this.IsSystemField = value;
                    this.RaisePropertyChanged("IsSystem");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDto", Namespace="http://schemas.datacontract.org/2004/07/MyNotes.Backend.Dtos")]
    [System.SerializableAttribute()]
    public partial class UserDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid GroupIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NicknameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public System.Guid GroupId {
            get {
                return this.GroupIdField;
            }
            set {
                if ((this.GroupIdField.Equals(value) != true)) {
                    this.GroupIdField = value;
                    this.RaisePropertyChanged("GroupId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GroupName {
            get {
                return this.GroupNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupNameField, value) != true)) {
                    this.GroupNameField = value;
                    this.RaisePropertyChanged("GroupName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
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
        public string Nickname {
            get {
                return this.NicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.NicknameField, value) != true)) {
                    this.NicknameField = value;
                    this.RaisePropertyChanged("Nickname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminServiceRef.IAdminService")]
    public interface IAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllGroups", ReplyAction="http://tempuri.org/IAdminService/GetAllGroupsResponse")]
        MyNotes.UI.Web.AdminServiceRef.GroupDto[] GetAllGroups();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllUsers", ReplyAction="http://tempuri.org/IAdminService/GetAllUsersResponse")]
        MyNotes.UI.Web.AdminServiceRef.UserDto[] GetAllUsers(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddGroup", ReplyAction="http://tempuri.org/IAdminService/AddGroupResponse")]
        bool AddGroup(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AddUser", ReplyAction="http://tempuri.org/IAdminService/AddUserResponse")]
        bool AddUser(string firstname, string lastname, string nickname, string username, string password, System.Guid groupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/UpdateGroup", ReplyAction="http://tempuri.org/IAdminService/UpdateGroupResponse")]
        bool UpdateGroup(System.Guid id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/UpdateUser", ReplyAction="http://tempuri.org/IAdminService/UpdateUserResponse")]
        bool UpdateUser(System.Guid id, string firstname, string lastname, string nickname, string username, string password, System.Guid groupId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminServiceChannel : MyNotes.UI.Web.AdminServiceRef.IAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminServiceClient : System.ServiceModel.ClientBase<MyNotes.UI.Web.AdminServiceRef.IAdminService>, MyNotes.UI.Web.AdminServiceRef.IAdminService {
        
        public AdminServiceClient() {
        }
        
        public AdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MyNotes.UI.Web.AdminServiceRef.GroupDto[] GetAllGroups() {
            return base.Channel.GetAllGroups();
        }
        
        public MyNotes.UI.Web.AdminServiceRef.UserDto[] GetAllUsers(System.Guid userId) {
            return base.Channel.GetAllUsers(userId);
        }
        
        public bool AddGroup(string name) {
            return base.Channel.AddGroup(name);
        }
        
        public bool AddUser(string firstname, string lastname, string nickname, string username, string password, System.Guid groupId) {
            return base.Channel.AddUser(firstname, lastname, nickname, username, password, groupId);
        }
        
        public bool UpdateGroup(System.Guid id, string name) {
            return base.Channel.UpdateGroup(id, name);
        }
        
        public bool UpdateUser(System.Guid id, string firstname, string lastname, string nickname, string username, string password, System.Guid groupId) {
            return base.Channel.UpdateUser(id, firstname, lastname, nickname, username, password, groupId);
        }
    }
}
