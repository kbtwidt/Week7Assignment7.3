namespace Week7Assignment7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(45);
            tree.Add(20);
            tree.Add(30);
            tree.Add(25);
            tree.Add(35);
            tree.Add(40);
            tree.Add(60);
            tree.Add(50);
            tree.Add(75);

            Console.WriteLine("Tree 1 In Order: ");
            tree.InOrder(tree.Root);

            Console.WriteLine("\nSearching Tree 1 for 30: ");
            tree.Search(30);
            Console.WriteLine("\nSearching Tree 1 for 80: ");
            tree.Search(80);
            Console.WriteLine("\nSearching Tree 1 for 45: ");
            tree.Search(45);
            Console.WriteLine("\nSearching Tree 1 for 60: ");
            Node result = tree.Search2(60);
            tree.InOrder(result);
            Console.WriteLine("\nSearching Tree 1 for 90: ");
            result = tree.Search2(90);
            tree.InOrder(result);

            BinarySearchTree tree2 = new BinarySearchTree();
            Console.WriteLine("\nSearching Tree 2 for 30: ");
            tree2.Search(30);
        }
    }
}
