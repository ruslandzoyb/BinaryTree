using System;
using System.Collections.Generic;
using System.Text;
using BinaryTree.EvensArgs;

namespace BinaryTree.Models
{
    
   public class Student:IComparable
    {
        private string name;
        private string surname;
        private int mark;
        private DateTime time;
        private string subject;
        public delegate void StudentHandler(object sender,StudentEventArgs e);
        public event StudentHandler Notify;
        public Student(string name,string surname,int mark,string subject)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.subject = subject ?? throw new ArgumentNullException(nameof(subject));
            if (mark>=0&&mark<=100)
            {
                this.mark = mark;
            }
            else
            {
                throw new Exception("Не верный формат оценки");
            }
            time = DateTime.Now;
            
        }

        public int CompareTo(object obj)
        {
            if (obj is Student student)
            {
                return mark.CompareTo(student.mark);
            }
            else
            {
                throw new Exception("");
            }
        }

        public void Change(string name,string surname)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("message", nameof(name));
            }

            if (string.IsNullOrEmpty(surname))
            {
                throw new ArgumentException("message", nameof(surname));
            }
            Notify?.Invoke(this, new StudentEventArgs("Изменены данные студента",
                this,
                name,
                surname ));

            this.name = name;
            this.surname = surname;
        }
        public override string ToString()
        {
            return String.Format($"Студент {name} {surname} сдал тест с {subject} на {mark}");
        }
        public static void StudentChangeInfo(object sender,StudentEventArgs e)
        {
            Console.WriteLine($"Студент {e.student.name} {e.student.surname} переименовался на {e.Name} {e.Surname} ");
        }

    }
}
