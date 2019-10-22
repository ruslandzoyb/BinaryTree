using System;
using System.Collections.Generic;
using System.Text;
using BinaryTree.Models;

namespace BinaryTree.EvensArgs
{
   public class StudentEventArgs
    {       

        public string Message { get;  }
        public Student student { get; }
        public string Name { get; }
        public string Surname { get; set; }

        public StudentEventArgs(string message,
           Student student,
           string name,
           string surname)
        {
            Message = message;
            this.student = student;
            Name = name;
            Surname = surname;
        }


    }
}
