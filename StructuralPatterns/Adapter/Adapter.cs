namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adptee;

        public Adapter(Adaptee adaptee)
        {
            this._adptee = adaptee;
        }
        public string GetRequest()
        {
            return $"This is '{this._adptee.GetSpecificRequest()}'";
        }
    }
}