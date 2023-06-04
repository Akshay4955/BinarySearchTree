namespace BinarySearchTree;

public class CustomBST
{
    private class Node
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
}
