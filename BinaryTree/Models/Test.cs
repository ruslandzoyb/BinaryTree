using System;

namespace BinaryTree
{
    [Serializable]
    public class Test
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public DateTime TestStart { get; set; }
        public DateTime TestFinish { get; set; }
        public DateTime Duration { get; set; }
        private Question[] questions;

        public Test(string name,Question[] questions)
        
        {
            
            Name = name ??name ?? throw new ArgumentNullException("message", nameof(name))  ;
            this.questions = questions ?? throw new ArgumentNullException(nameof(questions));
            
        }
    }
}
