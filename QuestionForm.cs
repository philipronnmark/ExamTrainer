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
            cboxAnswer.DataSource = Enum.GetValues(typeof(ABCD));
            

            //lblExamOnCreate.Text = exam.getExamName();
        }

        public QuestionForm(object chosenExam) : this()
        {
            this.exam = (Exam)chosenExam;
            lblExamOnCreate.Text = exam.getExamName();
            refreshExamQuestions();
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

        private bool checkFields()
        {
            if (String.IsNullOrEmpty(txtQuestion.Text))
            {
                string message = "Provide a question";
                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        private void clearFields()
        {
            txtQuestion.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            cboxAnswer.SelectedIndex = 0;


        }

        private void fillFields()
        {
            txtQuestion.Text = eq.getQuestion();
            txtA.Text = eq.getAlternatives()[0];
            txtB.Text = eq.getAlternatives()[1];
            txtC.Text = eq.getAlternatives()[2];
            txtD.Text = eq.getAlternatives()[3];
            cboxAnswer.SelectedItem = eq.getAnswer();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                string[] abcd = new string[4];
                abcd[0] = txtA.Text;
                abcd[1] = txtB.Text;
                abcd[2] = txtC.Text;
                abcd[3] = txtD.Text;
                eq = new ExamQuestion(txtQuestion.Text, (ABCD)cboxAnswer.SelectedItem, abcd);
                exam.addQuestion(eq);
                refreshExamQuestions();
                clearFields();
            }
        }

        private void lboxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //eq = (ExamQuestion)lboxQuestions.SelectedItem;
            //fillFields();

        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
