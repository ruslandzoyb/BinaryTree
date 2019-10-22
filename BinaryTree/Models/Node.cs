using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Models
{
   public class Node<T> : IComparable
        where T : IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Rigth { get; }
        public Node<T> Right { get; private set; }
        public Node(T data)
        {
            Data = data;



        }
        public Node(T data, Node<T> left, Node<T> rigth)
        {
            Data = data;
            Left = left;
            Rigth = rigth;
        }


        public void Add(T data)
        {
            if (data==null)
            {
                throw new Exception("");
            }
            else
            {
                var node = new Node<T>(data);

                if (node.Data.CompareTo(Data)==-1)
                {
                    if (Left==null)
                    {
                        Left = node;
                    }
                    else
                    {
                        Left.Add(data);
                    }
                }
                else
                {
                    if (Right==null)
                    {
                        Right = node;
                    }
                    else
                    {
                        Right.Add(data);
                    }

                }
            }

        }
        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new Exception("");
            }
        }

        
    }
}