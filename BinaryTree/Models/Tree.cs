using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Models
{
   public class Tree<T> 
        where T : IComparable
    {
        public Node<T> Root { get;  private set; }
        public int Counter { get; private set; }
        public delegate void NodeHandler(object sender, TreeEventArgs e) ;
        public event NodeHandler Notify;

        public void Add(T Data)
        {
            var node = new Node<T>(Data);
            if (Root == null)
            {
               Root = node;
                Counter = 1;
                var st = Data as Student;
                Notify?.Invoke(this, new TreeEventArgs(st, "Добавлен первый корень ", Counter));
            }
            else
            {
                Root.Add(Data);
                Counter++;
                var st = Data as Student;
                Notify?.Invoke(this, new TreeEventArgs(st, "Добавлен новый узел № ", Counter));
            }
                        
            
            
           
        }

        public List<T> Preordered()
        {
            if (Root==null)
            {
                return new List<T>();
            }
            else
            {
                return Preordered(Root);
            }
        }
        public List<T> Postordered()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            else
            {
                return Postordered(Root);
            }
        }
        public List<T> Inordered()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            else
            {
                return Inordered(Root);
            }
        }

        public  List<T> Preordered(Node<T> node)
        {
            var list = new List<T>();
            if (node!=null)
            {
                list.Add(node.Data);

                if (node.Left!=null)
                {
                    list.AddRange(Preordered(node.Left));
                }
                if (node.Right!=null)
                {
                    list.AddRange(Preordered(node.Right));
                }
            }
            return list;
        }

        public List<T> Postordered(Node<T> node)
        {
            var list = new List<T>();
            if (node!=null)
            {
                if (node.Left!=null)
                {
                    list.AddRange(Postordered(node.Left));
                }
                if (node.Right!=null)
                {
                    list.AddRange(Postordered(node.Right));
                }
                list.Add(node.Data);
            }
            return list;
        }

        public List<T> Inordered(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inordered(node.Left));
                }
                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(Inordered(node.Right));
                }
                
            }
            return list;
        }

        public void Change(T data)
        {
            var st = data as Student;
            st.Notify += Student.StudentChangeInfo;
        }

       
    }
}
