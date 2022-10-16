using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenilConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ServiceReference2.Service1Client service = new ServiceReference2.Service1Client();
            string choice = "";
            while (!choice.Equals("6"))

            {
                Console.WriteLine();
                Console.WriteLine("1. Prime Number Checker");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit.");
                Console.WriteLine("Enter your choice: _____");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Please enter a number: ");
                        int num = int.Parse(Console.ReadLine());

                        string str = service.IsPrimeNumber(num);
                        Console.WriteLine(str);
                        break;


                    case "2":
                         
                         Console.Write("Enter a number: ");
                        int digitnum = int.Parse(Console.ReadLine());

                        int sumResult = service.SumOfDigits(digitnum);
                         Console.WriteLine("Sum of digits is: " + sumResult);
                         break;

                     case "3":
                         Console.WriteLine("Please enter a string. ");
                        string resstr = Console.ReadLine();
                        string resultres = service.reverseString(resstr);
                         Console.WriteLine("Reverse string is" + resultres);
                         break;

                     case "4":
                         Console.WriteLine("Enter a Tag: ");
                         string tagString = Console.ReadLine();
                         Console.WriteLine("Enter a Data: ");
                         string dataString = Console.ReadLine();

                         string printData = service.printHTML(dataString, tagString);
                         Console.WriteLine(printData);
                         break;

                     case "5":
                         int i;
                         int[] arr = new int[5];
                         for (i = 0; i < 5; i++)
                         {
                             Console.Write("Enter your number:");
                             //Storing value in an array
                             arr[i] = Convert.ToInt32(Console.ReadLine());
                         }
                         bool arrBool = true;


                         do
                         {
                             Console.WriteLine("1. Ascending");
                             Console.WriteLine("2. Descending");
                             Console.WriteLine("Enter your choice ____");
                             int arrChoice = Int32.Parse(Console.ReadLine());

                             if (arrChoice == 1)
                             {
                                 arrBool = false;
                                 Array.Sort(arr);
                                 Console.WriteLine("Ascending Order of digits:");
                                 foreach (var item in arr)
                                 {
                                     Console.WriteLine(item.ToString());
                                 }
                             }
                             else if (arrChoice == 2)
                             {
                                 arrBool = false;
                                 Array.Sort(arr);
                                 Array.Reverse(arr);
                                 Console.WriteLine("Descending Order of digits:");
                                 foreach (var item in arr)
                                 {
                                     Console.WriteLine(item.ToString());
                                 }
                             }
                             else
                             {
                                 arrBool = true;
                                 Console.WriteLine("Please enter the correct choice.");
                             }
                         } while (arrBool);
                        break;

                    case "6":

                        break;

                }

            }

           
        }
    }
}
