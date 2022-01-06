using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTrainer
{
    class ExamManager
    {
        private ArrayList exams = new ArrayList();

        public void addExam(Exam e)
        {
            exams.Add(e);

        }

        public ArrayList GetExams()
        {
            return exams;
        }
    }
}
