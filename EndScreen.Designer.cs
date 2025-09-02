namespace QuizMaster
{
    partial class EndScreen
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
            this.lblEndQuizDialog = new System.Windows.Forms.Label();
            this.lblFinalScoreDialog = new System.Windows.Forms.Label();
            this.btnReturnHomepage = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEndQuizDialog
            // 
            this.lblEndQuizDialog.AutoSize = true;
            this.lblEndQuizDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEndQuizDialog.Location = new System.Drawing.Point(38, 53);
            this.lblEndQuizDialog.Name = "lblEndQuizDialog";
            this.lblEndQuizDialog.Size = new System.Drawing.Size(162, 25);
            this.lblEndQuizDialog.TabIndex = 0;
            this.lblEndQuizDialog.Text = "lblEndQuizDialog";
            // 
            // lblFinalScoreDialog
            // 
            this.lblFinalScoreDialog.AutoSize = true;
            this.lblFinalScoreDialog.Location = new System.Drawing.Point(40, 93);
            this.lblFinalScoreDialog.Name = "lblFinalScoreDialog";
            this.lblFinalScoreDialog.Size = new System.Drawing.Size(109, 13);
            this.lblFinalScoreDialog.TabIndex = 1;
            this.lblFinalScoreDialog.Text = "You Scored: --/-- (--%)";
            // 
            // btnReturnHomepage
            // 
            this.btnReturnHomepage.Location = new System.Drawing.Point(43, 130);
            this.btnReturnHomepage.Name = "btnReturnHomepage";
            this.btnReturnHomepage.Size = new System.Drawing.Size(115, 23);
            this.btnReturnHomepage.TabIndex = 2;
            this.btnReturnHomepage.Text = "Return to homepage";
            this.btnReturnHomepage.UseVisualStyleBackColor = true;
            this.btnReturnHomepage.Click += new System.EventHandler(this.btnReturnHomepage_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(164, 130);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(75, 23);
            this.btnRetry.TabIndex = 3;
            this.btnRetry.Text = "Retry Quiz";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(245, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 217);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnReturnHomepage);
            this.Controls.Add(this.lblFinalScoreDialog);
            this.Controls.Add(this.lblEndQuizDialog);
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Application_Close);
            this.Load += new System.EventHandler(this.EndScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEndQuizDialog;
        private System.Windows.Forms.Label lblFinalScoreDialog;
        private System.Windows.Forms.Button btnReturnHomepage;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnExit;
    }
}