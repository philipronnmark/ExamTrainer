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
    public partial class Form1 : Form
    {
        private ExamManager examManager = new ExamManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            exam.setExamName(txtExamName.Text);
            examManager.addExam(exam);


            refreshExamList();
        }

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

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            QuestionForm qForm = new QuestionForm((Exam)lboxExams.SelectedItem);
            //qForm.SetExam((Exam)lboxExams.SelectedItem);
            qForm.Show();
            
        }
    }
}
