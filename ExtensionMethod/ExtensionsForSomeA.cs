using dotnet_extension_method.BasicTypes;

namespace dotnet_extension_method.ExtensionMethod
{
    public static class ExtensionsForSomeA
    {
        public static string MethodA(this SomeA someA)
        {
            return "I'm in extension for SomeA type!";
        }
    }
}