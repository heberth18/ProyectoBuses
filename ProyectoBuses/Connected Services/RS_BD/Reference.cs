//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBuses.RS_BD {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RS_BD.DataBase_WSSoap")]
    public interface DataBase_WSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarPasajes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarPasajes(string rut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarPasajes", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarPasajesAsync(string rut);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DataBase_WSSoapChannel : ProyectoBuses.RS_BD.DataBase_WSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataBase_WSSoapClient : System.ServiceModel.ClientBase<ProyectoBuses.RS_BD.DataBase_WSSoap>, ProyectoBuses.RS_BD.DataBase_WSSoap {
        
        public DataBase_WSSoapClient() {
        }
        
        public DataBase_WSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataBase_WSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataBase_WSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataBase_WSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet ListarPasajes(string rut) {
            return base.Channel.ListarPasajes(rut);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarPasajesAsync(string rut) {
            return base.Channel.ListarPasajesAsync(rut);
        }
    }
}
