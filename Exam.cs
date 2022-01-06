﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTrainer
{
   class Exam
    {
        private ArrayList examQuestions = new ArrayList();

        private string examName;

        public string getExamName()
        {
            return examName;
        }

        public void setExamName(string eName)
        {
            examName = eName;
        }

        public int getNumOfQuestions()
        {
            return examQuestions.Count;
        }

        public ArrayList getQuestions()
        {
            return examQuestions;
        }

        public void addQuestion(ExamQuestion q)
        {
            examQuestions.Add(q);

        }

        public void removeQuestion(ExamQuestion q)
        {
            examQuestions.Remove(q);
        }

        public override string ToString()
        {
            
            return String.Format("Name: " + examName + " Num of questions: " + examQuestions.Count);
        }

    }
}
