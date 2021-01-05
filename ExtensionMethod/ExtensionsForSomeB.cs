using dotnet_extension_method.BasicTypes;

namespace dotnet_extension_method.ExtensionMethod
{
    public static class ExtensionsForSomeB
    {
        public static string MethodA(this SomeB someB)
        {
            return "I'm in extension for SomeB type!";
        }
    }
}