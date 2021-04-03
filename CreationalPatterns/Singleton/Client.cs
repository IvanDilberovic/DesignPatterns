using System.Threading;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public class Client
    {
        public void Main()
        {
            System.Console.WriteLine("{0}\n{1}\n{2}\n",
                                    "If you see the same value that means the singleton was reused.",
                                    "If you see different values then 2 singletons were created.",
                                    "RESULT:");

            Thread proc1 = new Thread(() => {
                TestSingleton("FOO");
            });

            Thread proc2 = new Thread(() => {
                TestSingleton("BAR");
            });

            proc1.Start();
            proc2.Start();

            proc1.Join();
            proc2.Join();
        }

        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            System.Console.WriteLine(singleton.Value);
        }
    }
}