namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public interface IAbstractProductB
    {
        string SomeFunctionB();

        string AnotherFunctionB(IAbstractProductA collabolator);
    }
}