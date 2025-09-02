using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaster
{
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();
        }
        private void EndScreen_Load(object sender, EventArgs e)
        {
            DisplayDialogs();
        }
        private int CalculatePercentage(double selection, double total)
        {
            return (int)((selection / total) * 100);
        }
        private void DisplayDialogs()
        {
            int scorePercentage = CalculatePercentage(QuestionPage.correctAnswers, LoadedQuizData.questionCount);
            if (scorePercentage > 50)
            {
                lblEndQuizDialog.Text = "Well done!";
            }
            else
            {
                lblEndQuizDialog.Text = "Better luck next time!";
            }
            lblFinalScoreDialog.Text = $"You scored: {QuestionPage.correctAnswers}/{LoadedQuizData.questionCount} ({scorePercentage}%)";
        }
        private void btnReturnHomepage_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
        private void btnRetry_Click(object sender, EventArgs e)
        {
            QuestionPage questionPage = new QuestionPage();
            questionPage.Show();
            this.Hide();
        }
        private void Application_Close(object sender, FormClosedEventArgs e) //Close button exits the program
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit button exits program
        {
            Application.Exit();
        }
    }
}
