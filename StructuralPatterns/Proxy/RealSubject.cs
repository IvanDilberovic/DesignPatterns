namespace DesignPatterns.StructuralPatterns.Proxy
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            System.Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}