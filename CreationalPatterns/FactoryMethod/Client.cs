namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            System.Console.WriteLine("App: Launched with ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            System.Console.WriteLine();

            System.Console.WriteLine("App: Launched with ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        public void ClientCode(Creator creator)
        {
            System.Console.WriteLine($"Client: I'm not aware of the creator's class, but it still works. {creator.SomeOperation()}");
        }
    }
}