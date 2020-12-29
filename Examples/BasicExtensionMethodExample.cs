using System.Collections.Generic;
using System.Linq;
using dotnet_extension_method.BasicTypes;
using dotnet_extension_method.ExtensionMethod;

namespace dotnet_extension_method.Examples
{
    public class BasicExtensionMethodExample
    {
        private SomeBasicType someBasicType = new SomeBasicType();

        public string BasicExtensionMethodUsageCase() => someBasicType.MethodB();

        // public string StaticCase() => SomeBasicType.MethodB();

        public string LinqExample()
        {
            var exampleList = new List<SomeBasicType>
            {
                new SomeBasicType("first 1"),
                new SomeBasicType("second 2"),
            };

            return exampleList.FirstOrDefault(someBasicType => someBasicType.SomeStringField == "first 1").SomeStringField;
        }

        public string SameNameCase() => someBasicType.MethodA();
    }
}