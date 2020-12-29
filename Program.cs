using System;
using dotnet_extension_method.Examples;

namespace dotnet_extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicExample = new BasicExtensionMethodExample();

            string result = string.Empty;

            // result = basicExample.BasicExtensionMethodUsageCase();

            // result = basicExample.LinqExample();

            // result = basicExample.StaticCase().

            // result = basicExample.SameNameCase();



            Console.WriteLine(result);
        }
    }
}
