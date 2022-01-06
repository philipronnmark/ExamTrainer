using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamTrainer
{
    public partial class QuestionForm : Form
    {
        private Exam exam;
        private ExamQuestion eq;


        public QuestionForm()
        { 
            InitializeComponent();
            
            //lblExamOnCreate.Text = exam.getExamName();
        }

        public QuestionForm(object chosenExam) : this()
        {
            this.exam = (Exam)chosenExam;
            lblExamOnCreate.Text = exam.getExamName();
        }

        private void refreshExamQuestions()
        {
            lboxQuestions.Items.Clear();
            foreach(ExamQuestion eq in exam.getQuestions())
            {
                lboxQuestions.Items.Add(eq);

            }
        }

        internal void SetExam(Exam e)
        {
            exam = e;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
