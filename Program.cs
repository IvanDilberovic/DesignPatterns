using System;
using DesignPatterns.CreationalPatterns.AbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n Creational pattern: AbstractFactory \n");
            new CreationalPatterns.AbstractFactory.Client().Main();
            
            System.Console.WriteLine("\n Creational pattern: Builder \n");
            new CreationalPatterns.Builder.Client().Main();

            System.Console.WriteLine("\n Creational pattern: FactoryMethod \n");
            new CreationalPatterns.FactoryMethod.Client().Main();

            System.Console.WriteLine("\n Creational pattern: Prototype \n");
            new CreationalPatterns.Prototype.Client().Main();

            System.Console.WriteLine("\n Creational pattern: Singleton \n");
            new CreationalPatterns.Singleton.Client().Main();
        }
    }
}
