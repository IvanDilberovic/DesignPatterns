namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class Client
    {
        public void Main()
        {
            System.Console.WriteLine("Client: Test code with first factory type...");
            ClientMethod(new ConcreteFactory1());
            System.Console.WriteLine();
            System.Console.WriteLine("Client: Test code with second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            System.Console.WriteLine(productA.SomeFunctionA());
            System.Console.WriteLine(productB.SomeFunctionB());
            System.Console.WriteLine(productB.AnotherFunctionB(productA));
        }
    }
}