using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JenilAssignment1WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string IsPrimeNumber(int number);

        [OperationContract]
        int SumOfDigits(int number);

        [OperationContract]
        string reverseString(string value);

        [OperationContract]
        string printHTML(string str, string tag);

        [OperationContract]
        int[] sortASc(int[] intArray);

        [OperationContract]
        int[] sortDesc(int[] intArray);
    }

    
}
