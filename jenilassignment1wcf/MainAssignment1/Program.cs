using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool MainMenu = true;
            while (MainMenu)
            {
                MainMenu = Menu();
            }
        }
        
        private static bool Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Prime Number Checker");
            Console.WriteLine("2. Sum of digits");
            Console.WriteLine("3. Reverse a string");
            Console.WriteLine("4. Print HTML tags");
            Console.WriteLine("5. Sort 5 numbers");
            Console.WriteLine("6. Exit.");
            Console.WriteLine("Enter your choice: _____");

            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Please enter a number: ");
                    long number = long.Parse(Console.ReadLine());
                    if (IsPrimeNumber(number))
                    {
                        Console.WriteLine("Prime Number");
                    }
                    else
                    {
                        Console.WriteLine("Not Prime Number");
                    }
                    return true;

                case "2":
                    int num, sum = 0, x;
                    Console.Write("Enter a number: ");
                    num = int.Parse(Console.ReadLine());
                    while (num > 0)
                    {
                        x = num % 10;
                        sum = sum + x;
                        num = num / 10;
                    }
                    Console.WriteLine("Sum of digits is: " + sum);
                    return true;

                case "3":
                    Console.WriteLine("Please enter a string. ");
                    string reverseString = Console.ReadLine();
                    char[] chars = reverseString.ToCharArray();
                    char[] result = new char[chars.Length];
                    for (int a = 0, b = reverseString.Length - 1; a < reverseString.Length; a++, b--)
                    {
                        result[a] = chars[b];
                    }
                    Console.WriteLine("Reverse string is" + result);
                    return true;

                case "4":
                    Console.WriteLine("Enter a Tag: ");
                    string tagString = Console.ReadLine();
                    Console.WriteLine("Enter a Data: ");
                    string dataString = Console.ReadLine();

                    Console.WriteLine("<"+tagString+">" + dataString + "</" + tagString + ">");
                    return true;

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
                    return true;

                case "6":

                  return false;

            }
            return true;
         }


        public static bool IsPrimeNumber(long number)
        {

            if (number == 1)
                return false;
            else if (number == 2)
                return true;
            else if (number % 2 == 0)
                return false;
            else
                return true;
        }

        public static string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }

        
    }
}
