﻿namespace ExamTrainer
{
    partial class QuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExamOnCreate = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxAnswer = new System.Windows.Forms.ComboBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lboxQuestions = new System.Windows.Forms.ListBox();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExamOnCreate
            // 
            this.lblExamOnCreate.AutoSize = true;
            this.lblExamOnCreate.Location = new System.Drawing.Point(205, 9);
            this.lblExamOnCreate.Name = "lblExamOnCreate";
            this.lblExamOnCreate.Size = new System.Drawing.Size(90, 13);
            this.lblExamOnCreate.TabIndex = 0;
            this.lblExamOnCreate.Text = "examBeingCrated";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(10, 19);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(315, 57);
            this.txtQuestion.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxAnswer);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuestion);
            this.groupBox1.Location = new System.Drawing.Point(22, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "D";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(222, 182);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(158, 20);
            this.txtD.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "C";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(222, 119);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(158, 20);
            this.txtC.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "B";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(23, 179);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(158, 20);
            this.txtB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correct answer";
            // 
            // cboxAnswer
            // 
            this.cboxAnswer.FormattingEnabled = true;
            this.cboxAnswer.Location = new System.Drawing.Point(362, 33);
            this.cboxAnswer.Name = "cboxAnswer";
            this.cboxAnswer.Size = new System.Drawing.Size(121, 21);
            this.cboxAnswer.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(23, 119);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(158, 20);
            this.txtA.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alternatives";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(345, 35);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(117, 23);
            this.btnAddQuestion.TabIndex = 7;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Finish Exam";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lboxQuestions
            // 
            this.lboxQuestions.FormattingEnabled = true;
            this.lboxQuestions.Location = new System.Drawing.Point(32, 35);
            this.lboxQuestions.Name = "lboxQuestions";
            this.lboxQuestions.Size = new System.Drawing.Size(279, 251);
            this.lboxQuestions.TabIndex = 9;
            this.lboxQuestions.SelectedIndexChanged += new System.EventHandler(this.lboxQuestions_SelectedIndexChanged);
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Location = new System.Drawing.Point(345, 74);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(117, 23);
            this.btnSaveQuestion.TabIndex = 10;
            this.btnSaveQuestion.Text = "Save Question";
            this.btnSaveQuestion.UseVisualStyleBackColor = true;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 607);
            this.Controls.Add(this.btnSaveQuestion);
            this.Controls.Add(this.lboxQuestions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblExamOnCreate);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExamOnCreate;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxAnswer;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lboxQuestions;
        private System.Windows.Forms.Button btnSaveQuestion;
    }
}