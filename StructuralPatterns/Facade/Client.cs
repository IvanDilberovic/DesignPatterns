namespace DesignPatterns.StructuralPatterns.Facade
{
    public class Client
    {
        public void Main()
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();

            Facade facade = new Facade(subsystem1, subsystem2);

            this.ClientCode(facade);
        }

        public void ClientCode(Facade facade)
        {
            System.Console.WriteLine(facade.Operation());
        }
    }
}