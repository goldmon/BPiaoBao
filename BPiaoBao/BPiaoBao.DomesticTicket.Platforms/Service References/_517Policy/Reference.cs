﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.19075
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPiaoBao.DomesticTicket.Platforms._517Policy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="_517Policy.BenefitInterfaceSoap")]
    public interface BenefitInterfaceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFacade", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string InterfaceFacade(string xmlParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MD5", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MD5(string plaintext);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BenefitInterfaceSoapChannel : BPiaoBao.DomesticTicket.Platforms._517Policy.BenefitInterfaceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BenefitInterfaceSoapClient : System.ServiceModel.ClientBase<BPiaoBao.DomesticTicket.Platforms._517Policy.BenefitInterfaceSoap>, BPiaoBao.DomesticTicket.Platforms._517Policy.BenefitInterfaceSoap {
        
        public BenefitInterfaceSoapClient() {
        }
        
        public BenefitInterfaceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BenefitInterfaceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BenefitInterfaceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BenefitInterfaceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InterfaceFacade(string xmlParam) {
            return base.Channel.InterfaceFacade(xmlParam);
        }
        
        public string MD5(string plaintext) {
            return base.Channel.MD5(plaintext);
        }
    }
}
