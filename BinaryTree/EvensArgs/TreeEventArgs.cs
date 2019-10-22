using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Models
{
   public class TreeEventArgs
    {
       
        public Student Student { get; }
        public string Message { get;  }
        public int Counter { get; }

        public TreeEventArgs(Student student, string message, int counter)
        {
            Student = student;
            Message = message;
            Counter = counter;
        }

    }
}
