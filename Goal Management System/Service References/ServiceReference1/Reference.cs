﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proooooooooooject.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/projectDemoServer")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/projectDemoServer")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Proooooooooooject.ServiceReference1.Roles[] StoreRolesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserPasswordField;
        
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
        public Proooooooooooject.ServiceReference1.Roles[] StoreRoles {
            get {
                return this.StoreRolesField;
            }
            set {
                if ((object.ReferenceEquals(this.StoreRolesField, value) != true)) {
                    this.StoreRolesField = value;
                    this.RaisePropertyChanged("StoreRoles");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserPassword {
            get {
                return this.UserPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.UserPasswordField, value) != true)) {
                    this.UserPasswordField = value;
                    this.RaisePropertyChanged("UserPassword");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Roles", Namespace="http://schemas.datacontract.org/2004/07/projectDemoServer")]
    [System.SerializableAttribute()]
    public partial class Roles : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Proooooooooooject.ServiceReference1.Goals[] StoreGoalsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Proooooooooooject.ServiceReference1.Goals[] StoreGoals {
            get {
                return this.StoreGoalsField;
            }
            set {
                if ((object.ReferenceEquals(this.StoreGoalsField, value) != true)) {
                    this.StoreGoalsField = value;
                    this.RaisePropertyChanged("StoreGoals");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Goals", Namespace="http://schemas.datacontract.org/2004/07/projectDemoServer")]
    [System.SerializableAttribute()]
    public partial class Goals : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GoalNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Proooooooooooject.ServiceReference1.To_Dos[] StoreToDoField;
        
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
        public string GoalName {
            get {
                return this.GoalNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GoalNameField, value) != true)) {
                    this.GoalNameField = value;
                    this.RaisePropertyChanged("GoalName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Proooooooooooject.ServiceReference1.To_Dos[] StoreToDo {
            get {
                return this.StoreToDoField;
            }
            set {
                if ((object.ReferenceEquals(this.StoreToDoField, value) != true)) {
                    this.StoreToDoField = value;
                    this.RaisePropertyChanged("StoreToDo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="To_Dos", Namespace="http://schemas.datacontract.org/2004/07/projectDemoServer")]
    [System.SerializableAttribute()]
    public partial class To_Dos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToDoField;
        
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
        public string Day {
            get {
                return this.DayField;
            }
            set {
                if ((object.ReferenceEquals(this.DayField, value) != true)) {
                    this.DayField = value;
                    this.RaisePropertyChanged("Day");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ToDo {
            get {
                return this.ToDoField;
            }
            set {
                if ((object.ReferenceEquals(this.ToDoField, value) != true)) {
                    this.ToDoField = value;
                    this.RaisePropertyChanged("ToDo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Proooooooooooject.ServiceReference1.CompositeType GetDataUsingDataContract(Proooooooooooject.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Proooooooooooject.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        void addUser(Proooooooooooject.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        System.Threading.Tasks.Task addUserAsync(Proooooooooooject.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchUser", ReplyAction="http://tempuri.org/IService1/searchUserResponse")]
        int searchUser(Proooooooooooject.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchUser", ReplyAction="http://tempuri.org/IService1/searchUserResponse")]
        System.Threading.Tasks.Task<int> searchUserAsync(Proooooooooooject.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchUserName", ReplyAction="http://tempuri.org/IService1/searchUserNameResponse")]
        int searchUserName(Proooooooooooject.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchUserName", ReplyAction="http://tempuri.org/IService1/searchUserNameResponse")]
        System.Threading.Tasks.Task<int> searchUserNameAsync(Proooooooooooject.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/changePassword", ReplyAction="http://tempuri.org/IService1/changePasswordResponse")]
        int changePassword(Proooooooooooject.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/changePassword", ReplyAction="http://tempuri.org/IService1/changePasswordResponse")]
        System.Threading.Tasks.Task<int> changePasswordAsync(Proooooooooooject.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addRoles", ReplyAction="http://tempuri.org/IService1/addRolesResponse")]
        void addRoles(Proooooooooooject.ServiceReference1.Roles role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addRoles", ReplyAction="http://tempuri.org/IService1/addRolesResponse")]
        System.Threading.Tasks.Task addRolesAsync(Proooooooooooject.ServiceReference1.Roles role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRoleslist", ReplyAction="http://tempuri.org/IService1/getRoleslistResponse")]
        Proooooooooooject.ServiceReference1.Roles[] getRoleslist();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRoleslist", ReplyAction="http://tempuri.org/IService1/getRoleslistResponse")]
        System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.Roles[]> getRoleslistAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteRoles", ReplyAction="http://tempuri.org/IService1/deleteRolesResponse")]
        void deleteRoles(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteRoles", ReplyAction="http://tempuri.org/IService1/deleteRolesResponse")]
        System.Threading.Tasks.Task deleteRolesAsync(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveRole", ReplyAction="http://tempuri.org/IService1/saveRoleResponse")]
        void saveRole(Proooooooooooject.ServiceReference1.Roles role, int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveRole", ReplyAction="http://tempuri.org/IService1/saveRoleResponse")]
        System.Threading.Tasks.Task saveRoleAsync(Proooooooooooject.ServiceReference1.Roles role, int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRoles", ReplyAction="http://tempuri.org/IService1/getRolesResponse")]
        Proooooooooooject.ServiceReference1.Roles getRoles(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRoles", ReplyAction="http://tempuri.org/IService1/getRolesResponse")]
        System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.Roles> getRolesAsync(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getGoalslist", ReplyAction="http://tempuri.org/IService1/getGoalslistResponse")]
        Proooooooooooject.ServiceReference1.Goals[] getGoalslist();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getGoalslist", ReplyAction="http://tempuri.org/IService1/getGoalslistResponse")]
        System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.Goals[]> getGoalslistAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addGoal", ReplyAction="http://tempuri.org/IService1/addGoalResponse")]
        void addGoal(Proooooooooooject.ServiceReference1.Goals goal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addGoal", ReplyAction="http://tempuri.org/IService1/addGoalResponse")]
        System.Threading.Tasks.Task addGoalAsync(Proooooooooooject.ServiceReference1.Goals goal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteGoal", ReplyAction="http://tempuri.org/IService1/deleteGoalResponse")]
        void deleteGoal(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteGoal", ReplyAction="http://tempuri.org/IService1/deleteGoalResponse")]
        System.Threading.Tasks.Task deleteGoalAsync(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveGoal", ReplyAction="http://tempuri.org/IService1/saveGoalResponse")]
        void saveGoal(Proooooooooooject.ServiceReference1.Goals goal, int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveGoal", ReplyAction="http://tempuri.org/IService1/saveGoalResponse")]
        System.Threading.Tasks.Task saveGoalAsync(Proooooooooooject.ServiceReference1.Goals goal, int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRoleType", ReplyAction="http://tempuri.org/IService1/getRoleTypeResponse")]
        string getRoleType(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRoleType", ReplyAction="http://tempuri.org/IService1/getRoleTypeResponse")]
        System.Threading.Tasks.Task<string> getRoleTypeAsync(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getGoal", ReplyAction="http://tempuri.org/IService1/getGoalResponse")]
        Proooooooooooject.ServiceReference1.Goals getGoal(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getGoal", ReplyAction="http://tempuri.org/IService1/getGoalResponse")]
        System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.Goals> getGoalAsync(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addToDo", ReplyAction="http://tempuri.org/IService1/addToDoResponse")]
        void addToDo(Proooooooooooject.ServiceReference1.To_Dos toDo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addToDo", ReplyAction="http://tempuri.org/IService1/addToDoResponse")]
        System.Threading.Tasks.Task addToDoAsync(Proooooooooooject.ServiceReference1.To_Dos toDo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getToDo", ReplyAction="http://tempuri.org/IService1/getToDoResponse")]
        Proooooooooooject.ServiceReference1.To_Dos getToDo(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getToDo", ReplyAction="http://tempuri.org/IService1/getToDoResponse")]
        System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.To_Dos> getToDoAsync(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getToDoList", ReplyAction="http://tempuri.org/IService1/getToDoListResponse")]
        Proooooooooooject.ServiceReference1.To_Dos[] getToDoList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getToDoList", ReplyAction="http://tempuri.org/IService1/getToDoListResponse")]
        System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.To_Dos[]> getToDoListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteToDo", ReplyAction="http://tempuri.org/IService1/deleteToDoResponse")]
        void deleteToDo(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteToDo", ReplyAction="http://tempuri.org/IService1/deleteToDoResponse")]
        System.Threading.Tasks.Task deleteToDoAsync(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveToDo", ReplyAction="http://tempuri.org/IService1/saveToDoResponse")]
        void saveToDo(Proooooooooooject.ServiceReference1.To_Dos toDo, int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveToDo", ReplyAction="http://tempuri.org/IService1/saveToDoResponse")]
        System.Threading.Tasks.Task saveToDoAsync(Proooooooooooject.ServiceReference1.To_Dos toDo, int index);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Proooooooooooject.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Proooooooooooject.ServiceReference1.IService1>, Proooooooooooject.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Proooooooooooject.ServiceReference1.CompositeType GetDataUsingDataContract(Proooooooooooject.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Proooooooooooject.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public void addUser(Proooooooooooject.ServiceReference1.User user) {
            base.Channel.addUser(user);
        }
        
        public System.Threading.Tasks.Task addUserAsync(Proooooooooooject.ServiceReference1.User user) {
            return base.Channel.addUserAsync(user);
        }
        
        public int searchUser(Proooooooooooject.ServiceReference1.User user) {
            return base.Channel.searchUser(user);
        }
        
        public System.Threading.Tasks.Task<int> searchUserAsync(Proooooooooooject.ServiceReference1.User user) {
            return base.Channel.searchUserAsync(user);
        }
        
        public int searchUserName(Proooooooooooject.ServiceReference1.User user) {
            return base.Channel.searchUserName(user);
        }
        
        public System.Threading.Tasks.Task<int> searchUserNameAsync(Proooooooooooject.ServiceReference1.User user) {
            return base.Channel.searchUserNameAsync(user);
        }
        
        public int changePassword(Proooooooooooject.ServiceReference1.User user) {
            return base.Channel.changePassword(user);
        }
        
        public System.Threading.Tasks.Task<int> changePasswordAsync(Proooooooooooject.ServiceReference1.User user) {
            return base.Channel.changePasswordAsync(user);
        }
        
        public void addRoles(Proooooooooooject.ServiceReference1.Roles role) {
            base.Channel.addRoles(role);
        }
        
        public System.Threading.Tasks.Task addRolesAsync(Proooooooooooject.ServiceReference1.Roles role) {
            return base.Channel.addRolesAsync(role);
        }
        
        public Proooooooooooject.ServiceReference1.Roles[] getRoleslist() {
            return base.Channel.getRoleslist();
        }
        
        public System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.Roles[]> getRoleslistAsync() {
            return base.Channel.getRoleslistAsync();
        }
        
        public void deleteRoles(int a) {
            base.Channel.deleteRoles(a);
        }
        
        public System.Threading.Tasks.Task deleteRolesAsync(int a) {
            return base.Channel.deleteRolesAsync(a);
        }
        
        public void saveRole(Proooooooooooject.ServiceReference1.Roles role, int index) {
            base.Channel.saveRole(role, index);
        }
        
        public System.Threading.Tasks.Task saveRoleAsync(Proooooooooooject.ServiceReference1.Roles role, int index) {
            return base.Channel.saveRoleAsync(role, index);
        }
        
        public Proooooooooooject.ServiceReference1.Roles getRoles(int index) {
            return base.Channel.getRoles(index);
        }
        
        public System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.Roles> getRolesAsync(int index) {
            return base.Channel.getRolesAsync(index);
        }
        
        public Proooooooooooject.ServiceReference1.Goals[] getGoalslist() {
            return base.Channel.getGoalslist();
        }
        
        public System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.Goals[]> getGoalslistAsync() {
            return base.Channel.getGoalslistAsync();
        }
        
        public void addGoal(Proooooooooooject.ServiceReference1.Goals goal) {
            base.Channel.addGoal(goal);
        }
        
        public System.Threading.Tasks.Task addGoalAsync(Proooooooooooject.ServiceReference1.Goals goal) {
            return base.Channel.addGoalAsync(goal);
        }
        
        public void deleteGoal(int a) {
            base.Channel.deleteGoal(a);
        }
        
        public System.Threading.Tasks.Task deleteGoalAsync(int a) {
            return base.Channel.deleteGoalAsync(a);
        }
        
        public void saveGoal(Proooooooooooject.ServiceReference1.Goals goal, int index) {
            base.Channel.saveGoal(goal, index);
        }
        
        public System.Threading.Tasks.Task saveGoalAsync(Proooooooooooject.ServiceReference1.Goals goal, int index) {
            return base.Channel.saveGoalAsync(goal, index);
        }
        
        public string getRoleType(int index) {
            return base.Channel.getRoleType(index);
        }
        
        public System.Threading.Tasks.Task<string> getRoleTypeAsync(int index) {
            return base.Channel.getRoleTypeAsync(index);
        }
        
        public Proooooooooooject.ServiceReference1.Goals getGoal(int index) {
            return base.Channel.getGoal(index);
        }
        
        public System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.Goals> getGoalAsync(int index) {
            return base.Channel.getGoalAsync(index);
        }
        
        public void addToDo(Proooooooooooject.ServiceReference1.To_Dos toDo) {
            base.Channel.addToDo(toDo);
        }
        
        public System.Threading.Tasks.Task addToDoAsync(Proooooooooooject.ServiceReference1.To_Dos toDo) {
            return base.Channel.addToDoAsync(toDo);
        }
        
        public Proooooooooooject.ServiceReference1.To_Dos getToDo(int index) {
            return base.Channel.getToDo(index);
        }
        
        public System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.To_Dos> getToDoAsync(int index) {
            return base.Channel.getToDoAsync(index);
        }
        
        public Proooooooooooject.ServiceReference1.To_Dos[] getToDoList() {
            return base.Channel.getToDoList();
        }
        
        public System.Threading.Tasks.Task<Proooooooooooject.ServiceReference1.To_Dos[]> getToDoListAsync() {
            return base.Channel.getToDoListAsync();
        }
        
        public void deleteToDo(int a) {
            base.Channel.deleteToDo(a);
        }
        
        public System.Threading.Tasks.Task deleteToDoAsync(int a) {
            return base.Channel.deleteToDoAsync(a);
        }
        
        public void saveToDo(Proooooooooooject.ServiceReference1.To_Dos toDo, int index) {
            base.Channel.saveToDo(toDo, index);
        }
        
        public System.Threading.Tasks.Task saveToDoAsync(Proooooooooooject.ServiceReference1.To_Dos toDo, int index) {
            return base.Channel.saveToDoAsync(toDo, index);
        }
    }
}
