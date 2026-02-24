using System;
using System.Configuration;

namespace project_with_secrets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var password = ConfigurationManager.AppSettings["password"];
            Console.WriteLine($"Password is {password}");
        }
    }
}