using System.Collections.Generic;
using System.Linq;
using dotnet_extension_method.BasicTypes;
using dotnet_extension_method.ExtensionMethod;

namespace dotnet_extension_method.Examples
{
    public class PolymorphismExample
    {
        private SomeA someA = new SomeA();
    
        private SomeB someB = new SomeB();

        public string BasicExample()
        {
            return "A :" + someA.MethodA() + "; B: " + someB.MethodA();
        }

        public string PolyExample()
        {
            List<SomeA> l = new List<SomeA>
            {
                new SomeA(),
                new SomeB()
            };

            return "A :" + l[0].MethodA() + "; B: " + l[1].MethodA();
        }

        public string ConvertBToA()
        {
            SomeA someConvertB = someB;
            return "B: " + someConvertB.MethodA();
        }
    }
}