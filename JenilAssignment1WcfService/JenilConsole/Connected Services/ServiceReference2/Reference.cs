﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JenilConsole.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsPrimeNumber", ReplyAction="http://tempuri.org/IService1/IsPrimeNumberResponse")]
        string IsPrimeNumber(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsPrimeNumber", ReplyAction="http://tempuri.org/IService1/IsPrimeNumberResponse")]
        System.Threading.Tasks.Task<string> IsPrimeNumberAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SumOfDigits", ReplyAction="http://tempuri.org/IService1/SumOfDigitsResponse")]
        int SumOfDigits(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SumOfDigits", ReplyAction="http://tempuri.org/IService1/SumOfDigitsResponse")]
        System.Threading.Tasks.Task<int> SumOfDigitsAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reverseString", ReplyAction="http://tempuri.org/IService1/reverseStringResponse")]
        string reverseString(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/reverseString", ReplyAction="http://tempuri.org/IService1/reverseStringResponse")]
        System.Threading.Tasks.Task<string> reverseStringAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/printHTML", ReplyAction="http://tempuri.org/IService1/printHTMLResponse")]
        string printHTML(string str, string tag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/printHTML", ReplyAction="http://tempuri.org/IService1/printHTMLResponse")]
        System.Threading.Tasks.Task<string> printHTMLAsync(string str, string tag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sortASc", ReplyAction="http://tempuri.org/IService1/sortAScResponse")]
        int[] sortASc(int[] intArray);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sortASc", ReplyAction="http://tempuri.org/IService1/sortAScResponse")]
        System.Threading.Tasks.Task<int[]> sortAScAsync(int[] intArray);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sortDesc", ReplyAction="http://tempuri.org/IService1/sortDescResponse")]
        int[] sortDesc(int[] intArray);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sortDesc", ReplyAction="http://tempuri.org/IService1/sortDescResponse")]
        System.Threading.Tasks.Task<int[]> sortDescAsync(int[] intArray);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : JenilConsole.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<JenilConsole.ServiceReference2.IService1>, JenilConsole.ServiceReference2.IService1 {
        
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
        
        public string IsPrimeNumber(int number) {
            return base.Channel.IsPrimeNumber(number);
        }
        
        public System.Threading.Tasks.Task<string> IsPrimeNumberAsync(int number) {
            return base.Channel.IsPrimeNumberAsync(number);
        }
        
        public int SumOfDigits(int number) {
            return base.Channel.SumOfDigits(number);
        }
        
        public System.Threading.Tasks.Task<int> SumOfDigitsAsync(int number) {
            return base.Channel.SumOfDigitsAsync(number);
        }
        
        public string reverseString(string value) {
            return base.Channel.reverseString(value);
        }
        
        public System.Threading.Tasks.Task<string> reverseStringAsync(string value) {
            return base.Channel.reverseStringAsync(value);
        }
        
        public string printHTML(string str, string tag) {
            return base.Channel.printHTML(str, tag);
        }
        
        public System.Threading.Tasks.Task<string> printHTMLAsync(string str, string tag) {
            return base.Channel.printHTMLAsync(str, tag);
        }
        
        public int[] sortASc(int[] intArray) {
            return base.Channel.sortASc(intArray);
        }
        
        public System.Threading.Tasks.Task<int[]> sortAScAsync(int[] intArray) {
            return base.Channel.sortAScAsync(intArray);
        }
        
        public int[] sortDesc(int[] intArray) {
            return base.Channel.sortDesc(intArray);
        }
        
        public System.Threading.Tasks.Task<int[]> sortDescAsync(int[] intArray) {
            return base.Channel.sortDescAsync(intArray);
        }
    }
}