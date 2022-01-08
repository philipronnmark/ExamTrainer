namespace ExamTrainer
{
    partial class MainForm
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
            this.lboxExams = new System.Windows.Forms.ListBox();
            this.btnPlayExam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateExam = new System.Windows.Forms.Button();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditExam = new System.Windows.Forms.Button();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnSaveToTxt = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxExams
            // 
            this.lboxExams.FormattingEnabled = true;
            this.lboxExams.Location = new System.Drawing.Point(12, 75);
            this.lboxExams.Name = "lboxExams";
            this.lboxExams.Size = new System.Drawing.Size(337, 212);
            this.lboxExams.TabIndex = 0;
            // 
            // btnPlayExam
            // 
            this.btnPlayExam.Location = new System.Drawing.Point(244, 307);
            this.btnPlayExam.Name = "btnPlayExam";
            this.btnPlayExam.Size = new System.Drawing.Size(105, 38);
            this.btnPlayExam.TabIndex = 1;
            this.btnPlayExam.Text = "Play Exam";
            this.btnPlayExam.UseVisualStyleBackColor = true;
            this.btnPlayExam.Click += new System.EventHandler(this.btnPlayExam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exam Trainer";
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.Location = new System.Drawing.Point(384, 139);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(116, 22);
            this.btnCreateExam.TabIndex = 3;
            this.btnCreateExam.Text = "Create Exam";
            this.btnCreateExam.UseVisualStyleBackColor = true;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(384, 113);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(116, 20);
            this.txtExamName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create exam";
            // 
            // btnEditExam
            // 
            this.btnEditExam.Location = new System.Drawing.Point(125, 308);
            this.btnEditExam.Name = "btnEditExam";
            this.btnEditExam.Size = new System.Drawing.Size(89, 37);
            this.btnEditExam.TabIndex = 7;
            this.btnEditExam.Text = "Edit Exam";
            this.btnEditExam.UseVisualStyleBackColor = true;
            this.btnEditExam.Click += new System.EventHandler(this.btnEditExam_Click);
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Location = new System.Drawing.Point(12, 308);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(88, 37);
            this.btnDeleteExam.TabIndex = 8;
            this.btnDeleteExam.Text = "Delete Exam";
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // btnSaveToTxt
            // 
            this.btnSaveToTxt.Location = new System.Drawing.Point(12, 9);
            this.btnSaveToTxt.Name = "btnSaveToTxt";
            this.btnSaveToTxt.Size = new System.Drawing.Size(88, 23);
            this.btnSaveToTxt.TabIndex = 9;
            this.btnSaveToTxt.Text = "Save to file";
            this.btnSaveToTxt.UseVisualStyleBackColor = true;
            this.btnSaveToTxt.Click += new System.EventHandler(this.btnSaveToTxt_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(12, 38);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(88, 23);
            this.btnLoadFromFile.TabIndex = 10;
            this.btnLoadFromFile.Text = "Load from file";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 370);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSaveToTxt);
            this.Controls.Add(this.btnDeleteExam);
            this.Controls.Add(this.btnEditExam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.btnCreateExam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayExam);
            this.Controls.Add(this.lboxExams);
            this.Name = "MainForm";
            this.Text = "Exam Trainer by Philip Rönnmark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxExams;
        private System.Windows.Forms.Button btnPlayExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditExam;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Button btnSaveToTxt;
        private System.Windows.Forms.Button btnLoadFromFile;
    }
}

