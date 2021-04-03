namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string AnotherFunctionB(IAbstractProductA collabolator)
        {
            var result = collabolator.SomeFunctionA();

            return $@"The result of B2 collaborating with the ({result})";
        }

        public string SomeFunctionB()
        {
            return "The result of product B2";
        }
    }
}