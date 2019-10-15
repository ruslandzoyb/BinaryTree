using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Models
{
    [Serializable]
   public class Student
    {
        private string name;
        private string surname;
        private Test test;

        public Student(string name,string surname,Test test)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.surname = surname;
            this.test = test ?? throw new ArgumentNullException(nameof(test));
        }

    }
}
