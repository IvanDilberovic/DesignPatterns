namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class Client
    {
        public void Main()
        {
            Abstraction abstraction = new Abstraction(new ConcreteImplementationA());
            this.ClientCode(abstraction);

            abstraction = new Abstraction(new ConcreteImplementationB());
            this.ClientCode(abstraction);
        }

        public void ClientCode(Abstraction abstraction)
        {
            System.Console.WriteLine(abstraction.Operation());
        }
    }
}