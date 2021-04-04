namespace DesignPatterns.StructuralPatterns.Facade
{
    public class Facade
    {
        protected Subsystem1 _subSystem1;
        protected Subsystem2 _subSystem2;

        public Facade(Subsystem1 subSystem1, Subsystem2 subSystem2)
        {
            this._subSystem1 = subSystem1;
            this._subSystem2 = subSystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystem:\n";
            result += this._subSystem1.Operation1();
            result += this._subSystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subSystem1.OperationN();
            result += this._subSystem2.OperationZ();
            return result;
        }
    }
}