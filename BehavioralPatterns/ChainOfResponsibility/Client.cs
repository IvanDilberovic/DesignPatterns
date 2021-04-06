using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class Client
    {
        public void Main()
        {
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            System.Console.WriteLine($"Chain: Monkey -> Squirrel -> Dog \n");
            this.ClientCode(monkey);

            System.Console.WriteLine($"Subchain: Squirrel -> Dog \n");
            this.ClientCode(squirrel);
        }

        public void ClientCode(AbstractHandler handler)
        {
           List<string> food = new List<string>() { "MeatBall", "Banana", "Apple" };

           foreach (var item in food)
           {
               System.Console.WriteLine($"Client: Who wants a {item}?");

               var result = handler.Handle(item);

               if (result != null)
               {
                   System.Console.WriteLine($"{result}");
               }
               else
               {
                   System.Console.WriteLine($"{item} was left untouched.");
               }
           }
        }
    }
}