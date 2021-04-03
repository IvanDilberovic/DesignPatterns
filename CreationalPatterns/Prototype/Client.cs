namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class Client
    {
        public void Main()
        {
            Person p1 = new Person();
            p1.Age = 35;
            p1.BirthDate = new System.DateTime(1985,12,11);
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            Person p2 = p1.ShallowCopy();
            Person p3 = p1.DeepCopy();

            System.Console.WriteLine("Original values of p1, p2, p3");
            System.Console.WriteLine("p1");
            DisplayValues(p1);
            System.Console.WriteLine("p2");
            DisplayValues(p2);
            System.Console.WriteLine("p3");
            DisplayValues(p3);

            //Change the values
            p1.Age = 55;
            p1.BirthDate = new System.DateTime();
            p1.Name = "John Doe";
            p1.IdInfo.IdNumber = 6969;

            System.Console.WriteLine("Values of p1, p2, p3 after the change");
            System.Console.WriteLine("p1");
            DisplayValues(p1);
            System.Console.WriteLine("p2 (shallow copy - reference values have changed)");
            DisplayValues(p2);
            System.Console.WriteLine("p3 (deep copy - everything was kept the same)");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p)
        {
            System.Console.WriteLine($"Name: {p.Name}, Age: {p.Age}, BirthDate: {p.BirthDate}");
            System.Console.WriteLine($"ID#: {p.IdInfo.IdNumber}");
        }
    }
}