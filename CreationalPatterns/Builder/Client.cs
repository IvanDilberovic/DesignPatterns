namespace DesignPatterns.CreationalPatterns.Builder
{
    public class Client
    {
        public void Main()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            System.Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            System.Console.WriteLine(builder.GetProduct().ListParts());

            System.Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            System.Console.WriteLine(builder.GetProduct().ListParts());

            System.Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            System.Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}