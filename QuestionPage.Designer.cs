namespace QuizMaster
{
    partial class QuestionPage
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
            this.lblQuestionDialog = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestionCounter = new System.Windows.Forms.Label();
            this.lblCorrectAnswerCount = new System.Windows.Forms.Label();
            this.lbl_IncorrectAnswerCount = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAnswerStatus = new System.Windows.Forms.Label();
            this.btnAbortQuiz = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblQuestionDialog
            // 
            this.lblQuestionDialog.AutoSize = true;
            this.lblQuestionDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuestionDialog.Location = new System.Drawing.Point(36, 58);
            this.lblQuestionDialog.Name = "lblQuestionDialog";
            this.lblQuestionDialog.Size = new System.Drawing.Size(133, 20);
            this.lblQuestionDialog.TabIndex = 0;
            this.lblQuestionDialog.Text = "lblQuestionDialog";
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(86, 102);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(129, 20);
            this.answerBox.TabIndex = 1;
            this.answerBox.TextChanged += new System.EventHandler(this.answerBox_TextChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(35, 105);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblQuestionCounter
            // 
            this.lblQuestionCounter.AutoSize = true;
            this.lblQuestionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestionCounter.Location = new System.Drawing.Point(22, 30);
            this.lblQuestionCounter.Name = "lblQuestionCounter";
            this.lblQuestionCounter.Size = new System.Drawing.Size(93, 17);
            this.lblQuestionCounter.TabIndex = 3;
            this.lblQuestionCounter.Text = "Question --/--";
            // 
            // lblCorrectAnswerCount
            // 
            this.lblCorrectAnswerCount.AutoSize = true;
            this.lblCorrectAnswerCount.Location = new System.Drawing.Point(135, 30);
            this.lblCorrectAnswerCount.Name = "lblCorrectAnswerCount";
            this.lblCorrectAnswerCount.Size = new System.Drawing.Size(53, 13);
            this.lblCorrectAnswerCount.TabIndex = 4;
            this.lblCorrectAnswerCount.Text = "Correct: 0";
            // 
            // lbl_IncorrectAnswerCount
            // 
            this.lbl_IncorrectAnswerCount.AutoSize = true;
            this.lbl_IncorrectAnswerCount.Location = new System.Drawing.Point(210, 30);
            this.lbl_IncorrectAnswerCount.Name = "lbl_IncorrectAnswerCount";
            this.lbl_IncorrectAnswerCount.Size = new System.Drawing.Size(61, 13);
            this.lbl_IncorrectAnswerCount.TabIndex = 5;
            this.lbl_IncorrectAnswerCount.Text = "Incorrect: 0";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(120, 145);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(71, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAnswerStatus
            // 
            this.lblAnswerStatus.AutoSize = true;
            this.lblAnswerStatus.Location = new System.Drawing.Point(340, 105);
            this.lblAnswerStatus.Name = "lblAnswerStatus";
            this.lblAnswerStatus.Size = new System.Drawing.Size(82, 13);
            this.lblAnswerStatus.TabIndex = 8;
            this.lblAnswerStatus.Text = "lblAnswerStatus";
            // 
            // btnAbortQuiz
            // 
            this.btnAbortQuiz.Location = new System.Drawing.Point(40, 145);
            this.btnAbortQuiz.Name = "btnAbortQuiz";
            this.btnAbortQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnAbortQuiz.TabIndex = 9;
            this.btnAbortQuiz.Text = "Abort Quiz";
            this.btnAbortQuiz.UseVisualStyleBackColor = true;
            this.btnAbortQuiz.Click += new System.EventHandler(this.btnAbortQuiz_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Location = new System.Drawing.Point(200, 145);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(82, 23);
            this.btnNextQuestion.TabIndex = 10;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(80, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 50);
            this.panel1.TabIndex = 11;
            // 
            // QuestionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 186);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnAbortQuiz);
            this.Controls.Add(this.lblAnswerStatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbl_IncorrectAnswerCount);
            this.Controls.Add(this.lblCorrectAnswerCount);
            this.Controls.Add(this.lblQuestionCounter);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.lblQuestionDialog);
            this.Name = "QuestionPage";
            this.Text = "QuizMaster";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Application_Close);
            this.Load += new System.EventHandler(this.QuestionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionDialog;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestionCounter;
        private System.Windows.Forms.Label lblCorrectAnswerCount;
        private System.Windows.Forms.Label lbl_IncorrectAnswerCount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAnswerStatus;
        private System.Windows.Forms.Button btnAbortQuiz;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Panel panel1;
    }
}