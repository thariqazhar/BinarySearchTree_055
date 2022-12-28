using System;

namespace BinarySearchTree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //constructor for the node class

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    /*a node class consist of three things, the information,
     * references to the right child, and references to the left child.*/

    class program
    {
        public Node ROOT;
        public program()
        {
            ROOT = null; /* initializing ROOT to null*/
        }

        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /* this function searchs the currentNode of the specified Node as well
             as the currentNode of its parents.*/
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
    }
}