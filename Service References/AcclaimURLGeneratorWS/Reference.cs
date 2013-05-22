﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccUrlGeneratorWS.AcclaimURLGeneratorWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AcclaimURLGeneratorWS.AcclaimURLGeneratorSoap")]
    public interface AcclaimURLGeneratorSoap {
        
        // CODEGEN: Generating message contract since element name userName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GenerateUrl", ReplyAction="*")]
        AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlResponse GenerateUrl(AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateUrlRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateUrl", Namespace="http://tempuri.org/", Order=0)]
        public AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlRequestBody Body;
        
        public GenerateUrlRequest() {
        }
        
        public GenerateUrlRequest(AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateUrlRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string participantId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string blowPass;
        
        public GenerateUrlRequestBody() {
        }
        
        public GenerateUrlRequestBody(string userName, string participantId, string blowPass) {
            this.userName = userName;
            this.participantId = participantId;
            this.blowPass = blowPass;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateUrlResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateUrlResponse", Namespace="http://tempuri.org/", Order=0)]
        public AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlResponseBody Body;
        
        public GenerateUrlResponse() {
        }
        
        public GenerateUrlResponse(AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GenerateUrlResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GenerateUrlResult;
        
        public GenerateUrlResponseBody() {
        }
        
        public GenerateUrlResponseBody(string GenerateUrlResult) {
            this.GenerateUrlResult = GenerateUrlResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AcclaimURLGeneratorSoapChannel : AccUrlGeneratorWS.AcclaimURLGeneratorWS.AcclaimURLGeneratorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AcclaimURLGeneratorSoapClient : System.ServiceModel.ClientBase<AccUrlGeneratorWS.AcclaimURLGeneratorWS.AcclaimURLGeneratorSoap>, AccUrlGeneratorWS.AcclaimURLGeneratorWS.AcclaimURLGeneratorSoap {
        
        public AcclaimURLGeneratorSoapClient() {
        }
        
        public AcclaimURLGeneratorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AcclaimURLGeneratorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AcclaimURLGeneratorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AcclaimURLGeneratorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlResponse AccUrlGeneratorWS.AcclaimURLGeneratorWS.AcclaimURLGeneratorSoap.GenerateUrl(AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlRequest request) {
            return base.Channel.GenerateUrl(request);
        }
        
        public string GenerateUrl(string userName, string participantId, string blowPass) {
            AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlRequest inValue = new AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlRequest();
            inValue.Body = new AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.participantId = participantId;
            inValue.Body.blowPass = blowPass;
            AccUrlGeneratorWS.AcclaimURLGeneratorWS.GenerateUrlResponse retVal = ((AccUrlGeneratorWS.AcclaimURLGeneratorWS.AcclaimURLGeneratorSoap)(this)).GenerateUrl(inValue);
            return retVal.Body.GenerateUrlResult;
        }
    }
}
