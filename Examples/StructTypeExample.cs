using System.Collections.Generic;
using System.Linq;
using dotnet_extension_method.BasicTypes;
using dotnet_extension_method.ExtensionMethod;

namespace dotnet_extension_method.Examples
{
    public class StructTypeExample
    {
        private StructType structType = new StructType(1, 1);

        public string ChangeStructReferenceValue()
        {
            var structTypeRef = structType;

            structTypeRef.X = 2;
            structTypeRef.Y = 2;

            return "Origin: " + structType.ToString() + " Ref: " + structTypeRef.ToString();
        }

        public string UsingThisModifier()
        {
            structType.UsingThis();

            return structType.ToString();
        }

        public string UsingRefModifier()
        {
            structType.UsingRef();

            return structType.ToString();
        }
    }
}