using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTrainer
{
    class ExamQuestion
    {
        private string question;
        private ABCD answer;
        private string[] alternatives = new string[3];

        public ExamQuestion(string q, ABCD ans, string[] alts)
        {
            question = q;
            answer = ans;
            alternatives = alts;
        }

        public string getQuestion()
        {
            return question;

        }

        

        public string[] getAlternatives()
        {
            return alternatives;
        }

        public ABCD getAnswer()
        {
            return answer;
        }

        public override string ToString()
        {

            return String.Format("Name: " + question);
        }



    }
}
