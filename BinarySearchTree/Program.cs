namespace BinarySearchTree;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to binary search tree...!!");
        Console.WriteLine("------------------------------------");
        CustomBST myBST = new CustomBST();

        myBST.Add(56);
        myBST.Add(30);
        myBST.Add(70);
        myBST.Add(22);
        myBST.Add(40);
        myBST.Add(60);
        myBST.Add(95);

        Console.WriteLine("Node is found or Not : " + myBST.Search(22));
        Console.WriteLine("Node is found or Not : " + myBST.Search(45));
        Console.WriteLine();

        Console.WriteLine("Preorder traversal of tree is :");
        Console.WriteLine("-----------------------------------------------");
        myBST.DisplayPreorder(myBST.GetRoot());
    }
}