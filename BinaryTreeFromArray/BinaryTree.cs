using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeFromArray
{
    public class BinaryTree
    {
        public Node Root;
        public class Node
        {
            public int Data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                Data = data;
            }
        }

            public Node BuildBinaryTree(int data, Node head)
            {                
                    if (head == null)
                    {
                        var newnode = new Node(data);
                        head = newnode;
                        return head;

                    }
                    else 
                    {
                        if (head.Data>data)
                        {
                            head.left = BuildBinaryTree(data, head.left);
                        }
                        else
                        {
                            head.right = BuildBinaryTree(data, head.right);

                        }
                        return head;

                    }
            }
        public Node CreateBinaryTree(List<int> numbers, int start, int end)
        {
            if (start > end)
                return null;

            var mid = (start+end)/2;           
            
            var newnode = new Node(numbers[mid]);


            newnode.left=CreateBinaryTree(numbers, start, mid-1);
            newnode.right = CreateBinaryTree(numbers, mid+1,end);
                return newnode;           

        }
        public void PreOrder(Node head)
        {
            var current = head;
            if(current == null)
            {
                return;

            }
            Console.Write(current.Data+" ");
            PreOrder(current.left);
            PreOrder(head.right);
        }

    }

                

} 
