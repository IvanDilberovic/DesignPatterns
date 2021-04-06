namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}