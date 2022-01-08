///Philip Rönnmark 990513-4392 
using System;
using System.Collections;
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
    /// Plays an exam.
    /// Answer questions by selecting a radiobutton then clicking check answer.
    /// If you are wrong, another remaining question will be selected.
    /// When a question has been answered correctly it will be removed from the remaining questions.
    /// </summary>
    public partial class ExamPlayerForm : Form
    {
        private Exam exam;
        private ArrayList questions;
        private static Random rnd = new Random();
        private ExamQuestion eq;
        public ExamPlayerForm()
        {
            InitializeComponent();
            
        }

        public ExamPlayerForm(object chosenExam) : this()
        {
            exam = (Exam)chosenExam;
            this.Text = "Playing: " + exam.getExamName();
            questions = (ArrayList)exam.getQuestions().Clone();
            updateNumOfQuestions();
            selectRandomQuestion();

        }

        /// <summary>
        /// Updates remaining questions, E.g when a question been answerd correctly then it will update
        /// </summary>
        private void updateNumOfQuestions()
        {
            lblNumOfQuestions.Text = questions.Count.ToString();
        }

        /// <summary>
        /// Selects a random question based on remaining questions left
        /// </summary>
        private void selectRandomQuestion()
        {
            if (questions.Count > 0)
            {

                int r = rnd.Next(questions.Count);
                eq = (ExamQuestion)questions[r];
                displayQuestion();
            } else
            {
                MessageBox.Show("You have finished all questions");
                Close();
            }
        }

        /// <summary>
        /// Displays the selected question and its alternatives
        /// </summary>
        private void displayQuestion()
        {
            //Display question
            txtQuestion.Text = eq.getQuestion();
            //Display alternatives
            string[] alternatives = eq.getAlternatives();
            rbtnA.Text = alternatives[0];
            rbtnB.Text = alternatives[1];
            rbtnC.Text = alternatives[2];
            rbtnD.Text = alternatives[3];

        }

        /// <summary>
        /// Checks if answer is correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            if(isAnswerCorrect() == true)
            {
                string message = "Correct answer! Click ok to move to next question";
                MessageBox.Show(message);
                questions.Remove(eq);
                updateNumOfQuestions();
                selectRandomQuestion();

            } else
            {
                MessageBox.Show("Wrong answer");
                selectRandomQuestion();
            }
        }

        /// <summary>
        /// Checks is answer is correct
        /// </summary>
        /// <returns></returns>
        private bool isAnswerCorrect()
        {
            ABCD ans = eq.getAnswer(); //Convert enum to index
            if (rbtnA.Checked && ans == ABCD.A)
            {
                return true;
            }
            else if (rbtnB.Checked && ans == ABCD.B)
            {
                return true;
            }
            else if (rbtnC.Checked && ans == ABCD.C)
            {
                return true;
            }
            else if (rbtnD.Checked && ans == ABCD.D)
            {
                return true;
            }
            return false;
        }
    }
}
