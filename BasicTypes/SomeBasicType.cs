namespace dotnet_extension_method.BasicTypes
{
    public class SomeBasicType
    {
        public string SomeStringField { get; set; }

        public SomeBasicType()
        {
            
        }

        public SomeBasicType(string someStringField)
        {
            this.SomeStringField = someStringField;
        }

        public string MethodA()
        {
            return "Hi, I'm A.";
        }

        public static void ExampleStatic()
        {
        }
    }
}