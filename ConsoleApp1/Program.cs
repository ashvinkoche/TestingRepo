using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting application...");

            var calculator = new Calculator();

            const int AddValue = 20;

            var result = calculator.Add(10, AddValue);

            Console.WriteLine("Result: " + result);

            var userName = GetUserName();

            if (userName != null)
            {
                Console.WriteLine("Hello " + userName);
            }

            Console.WriteLine("Application finished.");
        }

        static string GetUserName()
        {
            return "Adam";
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            var result = a + b;

            return result;
        }

        public int Multiply(int a, int b)
        {
            var result = a * b;

            return result;
        }
    }
}

