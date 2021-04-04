namespace DesignPatterns.StructuralPatterns.Composite
{
    public class Client
    {
        public void Main()
        {
            Leaf leaf = new Leaf();
            System.Console.WriteLine("Client: I get a simple component:");
            this.ClientCode(leaf);

            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            System.Console.WriteLine("Client: Now I've got a composite tree:");
            this.ClientCode(tree);

            System.Console.WriteLine("Client: I don't need to check the components classes even when managing the tree:\n");
            this.ClientCode2(tree, leaf);
        }

        public void ClientCode(Component leaf)
        {
            System.Console.WriteLine($"RESULT: {leaf.Operation()}");;
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            System.Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}