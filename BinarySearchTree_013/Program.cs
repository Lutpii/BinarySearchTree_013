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
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /*initializing ROOT to null*/
        }
        public void insert(string element) /*Insert a node in the binary sesarch tree*/
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null) /*check if the node to be inserted already inserted or not*/
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else /*if the specified node is not present*/
            {
                tmp = new Node(element, null, null); /*creates a Node*/
                if (parent == null) /*if the trees is empty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if (string.Compare(element, parent.info) <0)
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
    }
}