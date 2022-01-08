///Philip Rönnmark 990513-4392 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamTrainer
{
    /// <summary>
    /// Mainform where you create exams, and choose which exam to play.
    /// </summary>
    public partial class MainForm : Form
    {
        private ExamManager examManager = new ExamManager();
        public MainForm()
        {
            InitializeComponent();
            btnLoadFromFile_Click(null, EventArgs.Empty); //Automatically loads some example exams.
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            exam.setExamName(txtExamName.Text);
            examManager.addExam(exam);
            txtExamName.Text = "";
            refreshExamList();
        }

        /// <summary>
        /// Refresh the listbox incase of added/removed exam
        /// </summary>
        private void refreshExamList()
        {
            lboxExams.Items.Clear();
            foreach(Exam e in examManager.GetExams())
            {
                lboxExams.Items.Add(e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opens question form and can edit the exams questions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditExam_Click(object sender, EventArgs e)
        {
            if (lboxExams.SelectedItem != null)
            {
                QuestionForm qForm = new QuestionForm((Exam)lboxExams.SelectedItem);
                qForm.ShowDialog();
                refreshExamList();

            }
            else
            {
                MessageBox.Show("Select exam");
            }

        }

        /// <summary>
        /// Exam to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayExam_Click(object sender, EventArgs e)
        {
            if(lboxExams.SelectedItem != null)
            {
                Exam ex = (Exam)lboxExams.SelectedItem;
                if (ex.getNumOfQuestions() > 0)
                {
                    ExamPlayerForm epForm = new ExamPlayerForm((Exam)lboxExams.SelectedItem);
                    epForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No questions in this exam");
                }
            }
            else
            {
                MessageBox.Show("Please Select an exam");
            }
        }

        /// <summary>
        /// Deletes selected exam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            if(lboxExams.SelectedItem != null)
            {
                examManager.deleteExam((Exam)lboxExams.SelectedItem);
                refreshExamList();

            } else
            {
                MessageBox.Show("Select exam");
            }
            
        }


        /// <summary>
        /// Saves the exams to txtfile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveToTxt_Click(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "exams.txt");
            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (Exam ex in examManager.GetExams())
                {
                    foreach(ExamQuestion eq in ex.getQuestions())
                    {
                        tw.WriteLine(string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", ex.getExamName(), eq.getQuestion(), eq.getAlternatives()[0], eq.getAlternatives()[1], eq.getAlternatives()[2], eq.getAlternatives()[3], eq.getAnswer()));
                    }
                    


                }
            }
        }

        /// <summary>
        /// Loads exams from txtfile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {

                string line;
                var path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "exams.txt");
                Console.WriteLine(path);
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                    new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                string[] words = line.Split('|');
                

                if (examManager.checkIfExamAlreadyExists(words[0]))
                {
                    string[] alts = new string[4];
                    alts[0] = words[2];
                    alts[1] = words[3];
                    alts[2] = words[4];
                    alts[3] = words[5];
                    ABCD ans = (ABCD)Enum.Parse(typeof(ABCD), words[6], true);
                    ExamQuestion eq = new ExamQuestion(words[1], ans, alts);
                    examManager.findExam(words[0]).addQuestion(eq);
                } else
                {
                    Exam ex = new Exam();
                    ex.setExamName(words[0]);
                    examManager.addExam(ex);
                    string[] alts = new string[4];
                    alts[0] = words[2];
                    alts[1] = words[3];
                    alts[2] = words[4];
                    alts[3] = words[5];
                    
                    string s = words[6];
                    ABCD weekDay1 = (ABCD)Enum.Parse(typeof(ABCD), s);
                    ExamQuestion eq = new ExamQuestion(words[1], weekDay1, alts);
                    ex.addQuestion(eq);
                }

                }
            refreshExamList();
                file.Close();


            
        }
    }
}
