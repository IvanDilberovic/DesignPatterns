namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "MeatBall")
            {
                return $"Dog: I'll eat the {request.ToString()}";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}