namespace ExamTrainer
{
    partial class ExamPlayerForm
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumOfQuestions = new System.Windows.Forms.Label();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnD = new System.Windows.Forms.RadioButton();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(11, 28);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(393, 70);
            this.txtQuestion.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuestion);
            this.groupBox1.Location = new System.Drawing.Point(89, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCheckAnswer);
            this.groupBox2.Controls.Add(this.rbtnD);
            this.groupBox2.Controls.Add(this.rbtnC);
            this.groupBox2.Controls.Add(this.rbtnB);
            this.groupBox2.Controls.Add(this.rbtnA);
            this.groupBox2.Location = new System.Drawing.Point(89, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 204);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alternatives";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Questions left:";
            // 
            // lblNumOfQuestions
            // 
            this.lblNumOfQuestions.AutoSize = true;
            this.lblNumOfQuestions.Location = new System.Drawing.Point(178, 34);
            this.lblNumOfQuestions.Name = "lblNumOfQuestions";
            this.lblNumOfQuestions.Size = new System.Drawing.Size(97, 13);
            this.lblNumOfQuestions.TabIndex = 5;
            this.lblNumOfQuestions.Text = "lblNumOfQuestions";
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(11, 47);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(85, 17);
            this.rbtnA.TabIndex = 0;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "radioButton1";
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(11, 119);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(85, 17);
            this.rbtnB.TabIndex = 1;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "radioButton2";
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Location = new System.Drawing.Point(235, 47);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(85, 17);
            this.rbtnC.TabIndex = 2;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "radioButton3";
            this.rbtnC.UseVisualStyleBackColor = true;
            // 
            // rbtnD
            // 
            this.rbtnD.AutoSize = true;
            this.rbtnD.Location = new System.Drawing.Point(235, 119);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(85, 17);
            this.rbtnD.TabIndex = 3;
            this.rbtnD.TabStop = true;
            this.rbtnD.Text = "radioButton4";
            this.rbtnD.UseVisualStyleBackColor = true;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(152, 163);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(87, 23);
            this.btnCheckAnswer.TabIndex = 4;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // ExamPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.lblNumOfQuestions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExamPlayerForm";
            this.Text = "ExamPlayerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumOfQuestions;
        private System.Windows.Forms.RadioButton rbtnD;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.Button btnCheckAnswer;
    }
}