﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_013
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        /*Constructor for the Node Class*/
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    /*a Node class consists of three things, the information, references to the right child, and references*/

    class BinaryTree
    {
        
    }
}