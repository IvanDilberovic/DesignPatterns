namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public interface IAbstractFactory
    {
         IAbstractProductA CreateProductA();
         IAbstractProductB CreateProductB();
    }
}