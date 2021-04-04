namespace DesignPatterns.StructuralPatterns.Proxy
{
    public class Client
    {
        public void Main()
        {
            System.Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            this.ClientCode(realSubject);
            System.Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            this.ClientCode(proxy);
        }

        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}