using System;


namespace BinaryTree
{
    [Serializable]
    public class Question
    {
        public string Quest { get; set; }
        private string[] answers;
        private string rightAnswer;

        public Question(string answer, string[] answers,ushort right)
        {
            if (string.IsNullOrEmpty(answer) )
            {
                throw new ArgumentException("message", nameof(answer));
            }

            if (answers == null)
            {
                throw new ArgumentNullException(nameof(answers));
            }
            
            if (right<=answers.Length-1)
            {
                rightAnswer = answers[right];
            }
            else
            {
                throw new Exception("Некоректный номер");
            }
            Quest = answer;
            this.answers = answers;


        }
    }
}
