using dotnet_extension_method.BasicTypes;

namespace dotnet_extension_method.ExtensionMethod
{
    public static class ExtensionForSomeBasicType
    {

        public static string MethodA(this SomeBasicType someBasicType)
        {
            return "I'm A in extension.";
        }

        public static string MethodB(this SomeBasicType someBasicType)
        {
            return "I'm B in extension.";
        }
    }
}