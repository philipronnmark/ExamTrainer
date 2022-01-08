///Philip Rönnmark 990513-4392 
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
    /// <summary>
    /// Form for managing questions for a specifc exam.
    /// You can edit, remove, add questions.
    /// </summary>
    public partial class QuestionForm : Form
    {
        private Exam exam;
        private ExamQuestion eq;


        public QuestionForm()
        { 
            InitializeComponent();
            cboxAnswer.DataSource = Enum.GetValues(typeof(ABCD));
        }

        public QuestionForm(object chosenExam) : this()
        {
            this.exam = (Exam)chosenExam;
            lblExamOnCreate.Text = "Editing: " + exam.getExamName();
            this.Text = "Editing: " + exam.getExamName();
            refreshExamQuestions();
            btnSaveChanges.Enabled = false;
        }

        /// <summary>
        /// Refresh exam questions
        /// </summary>
        private void refreshExamQuestions()
        {
            lboxQuestions.Items.Clear();
            foreach(ExamQuestion eq in exam.getQuestions())
            {
                lboxQuestions.Items.Add(eq);

            }
        }

        /// <summary>
        /// Check if question field is empty, cannot add a question without a question :)
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Clear fields for better UI experience.
        /// </summary>
        private void clearFields()
        {
            txtQuestion.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            cboxAnswer.SelectedIndex = 0;


        }

        /// <summary>
        /// Fill fields, used for better UI experience when editing fields.
        /// </summary>
        private void fillFields()
        {
            txtQuestion.Text = eq.getQuestion();
            txtA.Text = eq.getAlternatives()[0];
            txtB.Text = eq.getAlternatives()[1];
            txtC.Text = eq.getAlternatives()[2];
            txtD.Text = eq.getAlternatives()[3];
            cboxAnswer.SelectedItem = eq.getAnswer();
        }

        /// <summary>
        /// Adds question to exam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Delete question from exam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if(lboxQuestions.SelectedItem != null)
            {
                exam.removeQuestion((ExamQuestion)lboxQuestions.SelectedItem);
                refreshExamQuestions();

            }
            else
            {
                MessageBox.Show("You need to select a question");
            }
        }


        private void btnFinishExam_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Edits question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (lboxQuestions.SelectedItem != null)
            {
                eq = (ExamQuestion)lboxQuestions.SelectedItem;
                fillFields();
                btnSaveChanges.Enabled = true;
                btnAddQuestion.Enabled = false;
                btnEditQuestion.Enabled = false;
                btnDeleteQuestion.Enabled = false;

            }
            else
            {
                MessageBox.Show("You need to select a question");
            }
        }

        /// <summary>
        /// Saves the edit of a question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string[] abcd = new string[4];
            abcd[0] = txtA.Text;
            abcd[1] = txtB.Text;
            abcd[2] = txtC.Text;
            abcd[3] = txtD.Text;

            eq.setAlternatives(abcd);
            eq.setAnswer((ABCD)cboxAnswer.SelectedItem);
            eq.setQuestion(txtQuestion.Text);

            btnSaveChanges.Enabled = false;
            btnAddQuestion.Enabled = true;
            btnEditQuestion.Enabled = true;
            btnDeleteQuestion.Enabled = true;


            refreshExamQuestions();
            clearFields();
        }
    }
}
