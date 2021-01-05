using dotnet_extension_method.BasicTypes;

namespace dotnet_extension_method.ExtensionMethod
{
    public static class ExtensionsForStructType
    {

        public static void UsingThis(this StructType structType)
        {
            structType.X = 2;
        }

        // public static void UsingRef(this ref StructType structType)
        public static void UsingRef(ref this StructType structType)
        {
            structType.X =2;
        }
    }
}