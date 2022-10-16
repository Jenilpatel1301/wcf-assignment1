using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JenilAssignment1WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string IsPrimeNumber(int number)
        {
            
            int i;
            int m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    break;
                }
            }
            if (i > m)
            {
                return "Number is Prime";
            }
            else
            {
                return "Number is not Prime";
            }
        }

        public string printHTML(string str, string tag)
        {
            var printBuilder = new StringBuilder();
            printBuilder.Append("<" + tag + ">");
            printBuilder.Append(str);
            printBuilder.Append("</" + tag + ">");

            return printBuilder.ToString();
        }

        public string reverseString(string value)
        {
            char[] chars = value.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = value.Length - 1; i < value.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }

        public int[] sortASc(int[] intArray)
        {
            throw new NotImplementedException();
        }

        public int[] sortDesc(int[] intArray)
        {
            throw new NotImplementedException();
        }

        public int SumOfDigits(int number)
        {
            int x, sum = 0; 
            while (number > 0)
            {
                x = number % 10;
                sum = sum + x;
                number = number / 10;
            }
            return sum;
        }
    }
}
