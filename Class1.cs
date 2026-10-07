using System;
using System.Collections.Generic;
using System.Text;

namespace Week7Assignment7._3
{
    internal class Node
    {
        public int Data {  get; set; }
        public Node left;
        public Node right;
        public Node (int val)
        {
            this.Data = val;
            this.left = null;
            this.right = null;
        }
    }

    class BinarySearchTree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }
        public BinarySearchTree()
        {
            this.root = null;
        }
        public void Add (int val)
        {
            Node newNode = new Node(val);
            Node tempRoot = this.root;
            Node temp = null;
            if (this.Root == null)
            {
                this.root = newNode;
            }
            else
            {
                while (tempRoot != null)
                {
                    temp = tempRoot;
                    if(tempRoot.Data == val)
                    {
                        Console.WriteLine("Value already exists, duplicates not allowed.");
                        return;
                    }
                    else if (val <  tempRoot.Data)
                    {
                        tempRoot = tempRoot.left;
                    }
                    else
                    {
                        tempRoot = tempRoot.right;
                    }
                }
                if (val < temp.Data)
                {
                    temp.left = newNode;
                }
                else
                {
                    temp.right = newNode;
                }
            }
        }

        public void Search(int val)
        {
            Node temp = this.root;
            if (temp == null)
                Console.WriteLine("Tree is empty");
            while (temp != null)
            {
                if(temp.Data == val)
                {
                    InOrder(temp);
                    return;
                }
                else if ( val < temp.Data)
                {
                    temp = temp.left;
                }
                else
                {
                    temp = temp.right;
                }
            }
            if (temp == null && this.root != null)
            {
                Console.Write("null");
            }
        }
        public Node Search2(int val)
        {
            Node temp = this.root;

            while (temp != null)
            {
                if (temp.Data == val)
                {
                    return temp;
                }
                else if (val < temp.Data)
                {
                    temp = temp.left;
                }
                else
                {
                    temp = temp.right;
                }
            }

            return null;
        }
        public void InOrder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                InOrder(tempRoot.left);
                Console.Write(tempRoot.Data + " ");
                InOrder(tempRoot.right);
            }
        }
    }
}
