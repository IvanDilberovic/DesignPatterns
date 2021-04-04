namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class Client
    {
        public void Main()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            System.Console.WriteLine("Adaptee interface is incompatible with the client.");
            System.Console.WriteLine("But with adapter client can call it's method.");

            System.Console.WriteLine(target.GetRequest());
        }
    }
}