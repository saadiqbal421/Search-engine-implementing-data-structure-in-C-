using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{   
    public class Node
    {
        public int Id;
        public Node left;
        public Node right;
        public int height;
        public string title;
        public string keyw;
        public string abt;
    };
    public class AVL
    {

        public Node root;
        //public int max(int a, int b)
        public AVL()
        {
            root = null;
        }
        public int height(Node N)
        {
            if (N == null)
                return 0;
            return N.height;
        }

   
       public int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public Node newNode(int key)
        {
            Node node = new Node();
            node.Id = key;
            node.left = null;
            node.right = null;
            node.height = 1; 

            return (node);
        }
        public Node rightRotate(Node y)
        {
            Node x = y.left;
            Node T2 = x.right;

            // Perform rotation 
            x.right = y;
            y.left = T2;

            // Update heights 
            y.height = max(height(y.left),
                            height(y.right)) + 1;
            x.height = max(height(x.left), height(x.right)) + 1;

            return x;
        }
        public Node leftRotate(Node x)
        {
            Node y = x.right;
            Node T2 = y.left;

          
            y.left = x;
            x.right = T2;

            
            x.height = max(height(x.left), height(x.right)) + 1;
            y.height = max(height(y.left),height(y.right)) + 1;

            
            return y;
        }


        public int getBalance(Node N)
        {
            if (N == null)
                return 0;
            return height(N.left) -
                   height(N.right);
        }

        public Node insert(Node node, Node key)
        {
            if (node == null)
            {
                node = key;
                return node;
            }
            if (key.Id < node.Id)
                node.left = insert(node.left, key);
            else if (key.Id > node.Id)
                node.right = insert(node.right, key);
            else 
                return node;
            node.height = 1 + max(height(node.left),height(node.right));

            int balance = getBalance(node);

            if (balance > 1 && key.Id < node.left.Id)
                return rightRotate(node);

            if (balance < -1 && key.Id > node.right.Id)
                return leftRotate(node);

            if (balance > 1 && key.Id > node.left.Id)
            {
                node.left = leftRotate(node.left);
                return rightRotate(node);
            }

            if (balance < -1 && key.Id < node.right.Id)
            {
                node.right = rightRotate(node.right);
                return leftRotate(node);
            }
            return node;
        }


        public Node minValueNode(Node node)
        {
            Node current = node;

            /* loop down to find the leftmost leaf */
            while (current.left != null)
                current = current.left;

            return current;
        }
    }
}
//linklist for search
public class node
{
    public int data;
    public string title;
    public string abt;
    public string key;
    public node next;
};
public class link_list
{
    node head, tail;

public link_list()
    {
        head = tail = null;
    }
    public void enternode(node a)
    {
        if (head == null)
        {
            head = a;
            tail = head;
        }
        else
        {
            tail.next = a;
            tail = tail.next;
        }
    }

    public node Search(string k)
    {
        node temp = head;

        while (temp != null)
        {
            if (temp.key == k)
            {
                return temp;
            }
            temp = temp.next;
        }
        return null;
    }
};




