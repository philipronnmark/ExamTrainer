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
            foreach (Exam ex in exams)
            {
                if (e.getExamName() == ex.getExamName())
                {
                    return;
                }
            }
            exams.Add(e);

        }

        public bool checkIfExamAlreadyExists(string examName)
        {
            foreach(Exam ex in exams)
            {
                if(ex.getExamName() == examName)
                {
                    return true;
                }
            }
            return false;
        }

        public Exam findExam(string examName)
        {
            foreach (Exam ex in exams)
            {
                if (ex.getExamName() == examName)
                {
                    return ex;
                }
            }
            return null;
        }

        public void deleteExam(Exam e)
        {
            exams.Remove(e);
        }

        public ArrayList GetExams()
        {
            return exams;
        }
    }
}
