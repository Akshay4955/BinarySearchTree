namespace BinarySearchTree;

public class CustomBST
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
        }
    }

    private Node Root;
    public Node GetRoot()
    {
        return Root;
    }

    public void Add(int data)
    {
        Node newNode = new Node(data);

        if (Root == null)
        {
            Root = newNode;
            return;
        }

        Node tempNode = Root;

        while (tempNode != null)
        {
            if (newNode.Data < tempNode.Data)
            {
                if (tempNode.Left == null)
                {
                    tempNode.Left = newNode;
                    return;
                }
                tempNode = tempNode.Left;
            }

            else if (newNode.Data > tempNode.Data)
            {
                if (tempNode.Right == null)
                {
                    tempNode.Right = newNode;
                    return;
                }
                tempNode = tempNode.Right;
            }
            else
            {
                Console.WriteLine($"{data} is already present in tree");
                return;
            }
        }
    }

    public bool Search(int data)
    {
        if (Root == null)
        {
            return false;
        }

        Node tempNode = Root;

        while (tempNode != null)
        {
            if (data == tempNode.Data)
            {
                return true;
            }
            else if (data < tempNode.Data)
            {
                tempNode = tempNode.Left;
            }
            else if (data > tempNode.Data)
            {
                tempNode = tempNode.Right;
            }
        }

        return false;

    }

    public void DisplayPreorder(Node root)
    {
        if (root != null)
        {
            Console.Write("{0} ", root.Data);
            DisplayPreorder(root.Left);
            DisplayPreorder(root.Right);
        }
    }

    public void DisplayInorder(Node root)
    {
        if (root != null)
        {
            DisplayInorder(root.Left);
            Console.Write("{0} ", root.Data);
            DisplayPreorder(root.Right);
        }
    }
}
