using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor Injection
            ConstructorInjection constructorInjection = new ConstructorInjection(new Formate());
            constructorInjection.print();

            //Property Injection
            PropertyInjection propertyInjection = new PropertyInjection();
            Sam sam = new Sam();
            sam.Notify(propertyInjection, "Check property Injection.");

            //Method Ijection
            MethodInjection methodInjection = new MethodInjection();
            methodInjection.Run(new Service());


        }
    }
}
