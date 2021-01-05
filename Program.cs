using System;
using dotnet_extension_method.Examples;

namespace dotnet_extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicExample = new BasicExtensionMethodExample();

            var structTypeExample = new StructTypeExample();

            var polymorphismExample = new PolymorphismExample();

            string result = string.Empty;

            // result = basicExample.BasicExtensionMethodUsageCase();

            // result = basicExample.LinqExample();

            // result = basicExample.StaticCase().

            // result = basicExample.SameNameCase();

            // result = structTypeExample.ChangeStructReferenceValue();

            // result = structTypeExample.UsingThisModifier();

            // result = structTypeExample.UsingRefModifier();

            // result = polymorphismExample.BasicExample();

            // result = polymorphismExample.PolyExample();

            // result = polymorphismExample.ConvertBToA();

            Console.WriteLine(result);
        }
    }
}
