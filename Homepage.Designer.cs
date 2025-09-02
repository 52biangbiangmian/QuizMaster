namespace QuizMaster
{
    partial class Homepage
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
            this.label1 = new System.Windows.Forms.Label();
            this.dropDownFileSelection = new System.Windows.Forms.ComboBox();
            this.lblSelectQuestionFile = new System.Windows.Forms.Label();
            this.QuestionNumSelector = new System.Windows.Forms.NumericUpDown();
            this.lblQuizLength = new System.Windows.Forms.Label();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQuizDirectory = new System.Windows.Forms.Label();
            this.lblDocumentPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblBounds = new System.Windows.Forms.Label();
            this.checkBoxRandomise = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionNumSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to QuizMaster!";
            // 
            // dropDownFileSelection
            // 
            this.dropDownFileSelection.BackColor = System.Drawing.Color.White;
            this.dropDownFileSelection.Enabled = false;
            this.dropDownFileSelection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dropDownFileSelection.FormattingEnabled = true;
            this.dropDownFileSelection.Location = new System.Drawing.Point(200, 121);
            this.dropDownFileSelection.Name = "dropDownFileSelection";
            this.dropDownFileSelection.Size = new System.Drawing.Size(179, 21);
            this.dropDownFileSelection.Sorted = true;
            this.dropDownFileSelection.TabIndex = 1;
            this.dropDownFileSelection.SelectedIndexChanged += new System.EventHandler(this.dropDownFileSelection_SelectedIndexChanged);
            // 
            // lblSelectQuestionFile
            // 
            this.lblSelectQuestionFile.AutoSize = true;
            this.lblSelectQuestionFile.Location = new System.Drawing.Point(126, 124);
            this.lblSelectQuestionFile.Name = "lblSelectQuestionFile";
            this.lblSelectQuestionFile.Size = new System.Drawing.Size(65, 13);
            this.lblSelectQuestionFile.TabIndex = 2;
            this.lblSelectQuestionFile.Text = "Select quiz: ";
            // 
            // QuestionNumSelector
            // 
            this.QuestionNumSelector.Enabled = false;
            this.QuestionNumSelector.Location = new System.Drawing.Point(200, 146);
            this.QuestionNumSelector.Name = "QuestionNumSelector";
            this.QuestionNumSelector.Size = new System.Drawing.Size(48, 20);
            this.QuestionNumSelector.TabIndex = 3;
            this.QuestionNumSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQuizLength
            // 
            this.lblQuizLength.AutoSize = true;
            this.lblQuizLength.Location = new System.Drawing.Point(127, 148);
            this.lblQuizLength.Name = "lblQuizLength";
            this.lblQuizLength.Size = new System.Drawing.Size(67, 13);
            this.lblQuizLength.TabIndex = 4;
            this.lblQuizLength.Text = "Quiz Length:";
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Enabled = false;
            this.btnStartQuiz.Location = new System.Drawing.Point(257, 198);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnStartQuiz.TabIndex = 5;
            this.btnStartQuiz.Text = "Start Quiz!";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Location = new System.Drawing.Point(254, 148);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(52, 13);
            this.lblQuestions.TabIndex = 6;
            this.lblQuestions.Text = "questions";
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(458, 93);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(93, 23);
            this.btnSelectDirectory.TabIndex = 7;
            this.btnSelectDirectory.Text = "Select Directory";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblQuizDirectory
            // 
            this.lblQuizDirectory.AutoSize = true;
            this.lblQuizDirectory.Location = new System.Drawing.Point(115, 98);
            this.lblQuizDirectory.Name = "lblQuizDirectory";
            this.lblQuizDirectory.Size = new System.Drawing.Size(76, 13);
            this.lblQuizDirectory.TabIndex = 9;
            this.lblQuizDirectory.Text = "Quiz Directory:";
            // 
            // lblDocumentPath
            // 
            this.lblDocumentPath.AutoSize = true;
            this.lblDocumentPath.Location = new System.Drawing.Point(197, 98);
            this.lblDocumentPath.Name = "lblDocumentPath";
            this.lblDocumentPath.Size = new System.Drawing.Size(88, 13);
            this.lblDocumentPath.TabIndex = 10;
            this.lblDocumentPath.Text = "lblDocumentPath";
            // 
            // lblBounds
            // 
            this.lblBounds.AutoSize = true;
            this.lblBounds.Location = new System.Drawing.Point(312, 148);
            this.lblBounds.Name = "lblBounds";
            this.lblBounds.Size = new System.Drawing.Size(34, 13);
            this.lblBounds.TabIndex = 11;
            this.lblBounds.Text = "(1 - --)";
            // 
            // checkBoxRandomise
            // 
            this.checkBoxRandomise.AutoSize = true;
            this.checkBoxRandomise.Checked = true;
            this.checkBoxRandomise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRandomise.Location = new System.Drawing.Point(361, 147);
            this.checkBoxRandomise.Name = "checkBoxRandomise";
            this.checkBoxRandomise.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRandomise.TabIndex = 12;
            this.checkBoxRandomise.Text = "Randomise";
            this.checkBoxRandomise.UseVisualStyleBackColor = true;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 262);
            this.Controls.Add(this.checkBoxRandomise);
            this.Controls.Add(this.lblBounds);
            this.Controls.Add(this.lblDocumentPath);
            this.Controls.Add(this.lblQuizDirectory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.lblQuizLength);
            this.Controls.Add(this.QuestionNumSelector);
            this.Controls.Add(this.lblSelectQuestionFile);
            this.Controls.Add(this.dropDownFileSelection);
            this.Controls.Add(this.label1);
            this.Name = "Homepage";
            this.Text = "QuizMaster";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Application_Close);
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionNumSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropDownFileSelection;
        private System.Windows.Forms.Label lblSelectQuestionFile;
        private System.Windows.Forms.NumericUpDown QuestionNumSelector;
        private System.Windows.Forms.Label lblQuizLength;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblQuizDirectory;
        private System.Windows.Forms.Label lblDocumentPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblBounds;
        private System.Windows.Forms.CheckBox checkBoxRandomise;
    }
}

