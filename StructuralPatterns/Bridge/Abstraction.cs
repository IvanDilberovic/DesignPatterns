namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return $"Abstract: Base operation with: {_implementation.OperationImplementation()}";
        }
    }
}