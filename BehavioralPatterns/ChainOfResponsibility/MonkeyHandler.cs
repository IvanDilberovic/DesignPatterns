namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request.ToString()}";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}