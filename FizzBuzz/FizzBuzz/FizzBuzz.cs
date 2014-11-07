using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {

            for (int numb = 1; numb <= 100; numb++)
            {
                if (numb % 5 == 0 && numb % 3 == 0)
                {
                    Console.WriteLine(numb);
                }
                //else if (numb % 3 == 0)
                //{
                //    Console.WriteLine("Fizz");
                //}
                //else if (numb % 5 == 0)
                //{
                //    Console.WriteLine("Buzz");
                //}
                
                //else
                //{
                //    Console.WriteLine(numb);
                //}


            }


        }
    }
}
