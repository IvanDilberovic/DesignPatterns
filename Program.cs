using System;
using DesignPatterns.CreationalPatterns.AbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
             System.Console.WriteLine("\nCreational pattern: AbstractFactory \n");
             new CreationalPatterns.AbstractFactory.Client().Main();
            
             System.Console.WriteLine("\nCreational pattern: Builder \n");
             new CreationalPatterns.Builder.Client().Main();

             System.Console.WriteLine("\nCreational pattern: FactoryMethod \n");
             new CreationalPatterns.FactoryMethod.Client().Main();

             System.Console.WriteLine("\nCreational pattern: Prototype \n");
             new CreationalPatterns.Prototype.Client().Main();

             System.Console.WriteLine("\nCreational pattern: Singleton \n");
             new CreationalPatterns.Singleton.Client().Main();

             System.Console.WriteLine("\nStructural pattern: Adapter \n");
             new StructuralPatterns.Adapter.Client().Main();

             System.Console.WriteLine("\nStructural pattern: Bridge \n");
             new StructuralPatterns.Bridge.Client().Main();

             System.Console.WriteLine("\nStructural pattern: Composite \n");
             new StructuralPatterns.Composite.Client().Main();

             System.Console.WriteLine("\nStructural pattern: Decorator \n");
             new StructuralPatterns.Decorator.Client().Main();

             System.Console.WriteLine("\nStructural pattern: Facade \n");
             new StructuralPatterns.Facade.Client().Main();

             System.Console.WriteLine("\nStructural pattern: Proxy \n");
             new StructuralPatterns.Proxy.Client().Main();
        }
    }
}
