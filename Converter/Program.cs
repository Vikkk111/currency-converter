using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, welcome! Please use 'c' to use the currency conventer or anything else to use the temperature");
            string answer = Console.ReadLine();

            if (answer == "c")
            {
                Console.WriteLine("You have selected 'c'  thr currency cinverter");
                Console.WriteLine("Please select 'a' to convert from pounds or anything else to convert");
                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    Console.WriteLine("Please enter amount in British pounds");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    Console.WriteLine("The amount in euros is " + euros.ToString("0.00"));

                }
                else
                {
                    Console.WriteLine("Please enter your amount in euros");
                    float euros = float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    Console.WriteLine("The amount in British oiunds is " + pounds.ToString("0.00"));
                }
            }
            else
            {
                Console.WriteLine("Welcome to converter temperature");
                Console.WriteLine("Please enter 'a' to convert from celsius or anything else to convert from farenheit");
                string choices = Console.ReadLine();

                if (choices == "a")
                {
                    Console.WriteLine("Please enter a temperature in celsius");
                    float celsius = float.Parse(Console.ReadLine());
                    float farenheit = celsius * 1.18f + 32f;
                    Console.WriteLine("The temperature in farenheit is " + farenheit);


                }
                else {
                    Console.WriteLine("Please enter temperature in farenheit");
                    float farenheit = float.Parse(Console.ReadLine());
                    float celsius = (farenheit - 32) / 1.8f;
                    Console.WriteLine("The temperature in celsius is : " + celsius);

                }
            }
        }
    }
}

    

