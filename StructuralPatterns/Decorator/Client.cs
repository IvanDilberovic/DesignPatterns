namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class Client
    {
        public void Main()
        {
            var simple = new ConcreteComponent();
            System.Console.WriteLine("Client: I get a simple component");
            this.ClientCode(simple);

            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            System.Console.WriteLine("Client: Now I've got a decorated component:");
            this.ClientCode(decorator2);
        }

        public void ClientCode(Component component)
        {
            System.Console.WriteLine($"RESULT: {component.Operation()}");
        }
    }
}