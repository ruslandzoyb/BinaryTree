using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree.Models;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string f1 = "Math";
            string f2 = "English";
            try
            {
                Student[] students = new Student[]
                           {
               new Student("Ruslan","Dzoybko",5,f1),
               new Student("Vlad","Honchar",3,f1),
               new Student("Katerina","Slobodyanik",99,f2),
               new Student("Anna","Kovalchuk",1,f1),
               new Student("Inna","Honchar",4,f2),
               new Student("Alena","Kulisheva",7,f1),
               new Student("Ivan","Maluk",9,f2),
               new Student("Evhen","Tomilin",2,f1),
                           };
                var tree = new Tree<Student>();
                //tree.Notify += ShowMessage;
                foreach (var item in students)
                {
                    tree.Add(item);
                }
                foreach (var item in tree.Inordered())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                foreach (var item in tree.Inordered())
                {
                    item.Change("Ruslan", "Andrush");
                }
                foreach (var item in tree.Inordered())
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           


            // var list = tree.Inordered();
            
            Console.ReadKey();
        }
        private static void ShowMessage(object sender, TreeEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($" {e.Message} №{e.Counter} ,{e.Student} ");
        }
        
    }
}
