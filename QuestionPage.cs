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
    public partial class QuestionPage : Form
    {
        int currentQuestionNumber;
        public static int correctAnswers;
        int incorrectAnswers;
        int index;
        public QuestionPage()
        {
            InitializeComponent();
        }
        private void QuestionPage_Load(object sender, EventArgs e) //Key variables are reset to 0
        {
            currentQuestionNumber = 0;
            correctAnswers = 0;
            incorrectAnswers = 0;
            LoadQuestion();
        }
        private void LoadQuestion() //Displays the current question, chocie selection/text box, and its count.
        {
            answerBox.Clear();
            btnNextQuestion.Enabled = false;
            lblAnswerStatus.Text = "";
            answerBox.Enabled = false;
            answerBox.Hide(); //All controls where the user inputs an answer are hidden
            panel1.Controls.Clear();
            panel1.Hide();
            currentQuestionNumber++;
            if (Homepage.randomised) //Loads questions randomly if the user checked "Randomise" at the homepage
            {
                index = LoadedQuizData.questionNumbers.ToArray()[currentQuestionNumber - 1];
            }
            else
            {
                index = currentQuestionNumber - 1;
            }
            lblQuestionCounter.Text = $"Question: {currentQuestionNumber}/{LoadedQuizData.questionCount}";
            lblQuestionDialog.Text = TrimPrefix(LoadedQuizData.questions[index]); //Removes "Question:" from the string along with whitespace and displays it
            if (CheckMultipleChoice(index)) //If a question is multiple choice the radio buttons are generated
            {
                panel1.Show();
                for (int i = 0; i < LoadedQuizData.choices[index].Length; i++) //Radio buttons are generated vertically
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = TrimPrefix(LoadedQuizData.choices[index][i]);
                    radioButton.Location = new System.Drawing.Point(5, 15 + (25 * i));
                    radioButton.AutoSize = true;
                    radioButton.CheckedChanged += radioButton_CheckedChanged;
                    this.Size = new System.Drawing.Size(SetFormWidth(), 225 + (25 * i)); //Window size set to fit the radio buttons
                    panel1.Size = new System.Drawing.Size(255, 50 + (25 * i)); //Panel size set to fit radio buttons
                    btnAbortQuiz.Location = new System.Drawing.Point(40, 145 + (25 * i)); //Abort Quiz, Submit, and Next question are moved to fit radio buttons
                    btnSubmit.Location = new System.Drawing.Point(120, 145 + (25 * i));
                    btnNextQuestion.Location = new System.Drawing.Point(200, 145 + (25 * i));
                    panel1.Controls.Add(radioButton);
                }  
            }
            else //Otherwise the answer box is shown and sizes are set to default
            {
                ResetDimensions();
                answerBox.Show();
                answerBox.Enabled = true;
            }
            if (currentQuestionNumber  == LoadedQuizData.questionCount) //Checks if the current question is the last one
            {
                btnNextQuestion.Text = "End Quiz";  
            }

        }
        private int SetFormWidth() //Determines the width of the form, with consideration for the size of the question label
        {
            if (lblQuestionDialog.Right > 430)
            {
                return lblQuestionDialog.Right + 30;
            }
            else
            {
                return 450;
            }
        }
        private void ResetDimensions() //Resets dimensions/locations of the current form to default
        {
            this.Size = new System.Drawing.Size(SetFormWidth(), 225);
            panel1.Size = new System.Drawing.Size(255, 50);
            btnAbortQuiz.Location = new System.Drawing.Point(40, 145);
            btnSubmit.Location = new System.Drawing.Point(120, 145);
            btnNextQuestion.Location = new System.Drawing.Point(200, 145);
            lblAnswerStatus.Location = new System.Drawing.Point(220, 105);
        }
        private string TrimPrefix(string line) //Attempts to trim the prefix from a string, used to parse items from the lists
        {
            if (line.StartsWith("Question:"))
            {
                return line.Remove(0, 9).Trim();
            }
            else if (line.StartsWith("Choice:"))
            {
                return line.Remove(0, 7).Trim();
            }
            else if (line.StartsWith("Answer:"))
            {
                return line.Remove(0, 7).Trim();
            }
            else
            {
                return line;
            }
        }
        private bool CheckMultipleChoice(int index) //Checks if a question is multiple choice by checking if LoadedQuizData.choices has any items
        {
            return LoadedQuizData.choices[index].Count() > 0;
        }
        private void answerBox_TextChanged(object sender, EventArgs e) //Enables the Submit button if the text is entered, disables it when there is none
        {
            if (answerBox.Text != "")
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e) //When a radio button is selected, the submit button is enabled
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked && rb != null)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e) //The answer is submitted and validated.
        {
            
            btnSubmit.Enabled = false;
            string correctAnswer = TrimPrefix(LoadedQuizData.answers[index]).ToLower();
            if (CheckMultipleChoice(index))
            {
                int answerIndex = 0;
                foreach (RadioButton rb in panel1.Controls.OfType<RadioButton>())
                {
                    rb.Enabled = false;
                }
                foreach (RadioButton rb in panel1.Controls.OfType<RadioButton>())
                {
                    answerIndex++;
                    if (rb.Checked)
                    {
                        break;
                    }
                }
                if ((answerIndex).ToString() == correctAnswer)
                {
                    correctAnswers++;
                    lblCorrectAnswerCount.Text = $"Correct: {correctAnswers}";
                    foreach (RadioButton rb in panel1.Controls.OfType<RadioButton>())
                    {
                        if (rb.Checked)
                        {
                            PlaceIcon(rb, true); 
                        }
                    }

                }
                else
                {
                    incorrectAnswers++;
                    lbl_IncorrectAnswerCount.Text = $"Incorrect: {incorrectAnswers}";
                    int i = 0;
                    foreach (RadioButton rb in panel1.Controls.OfType<RadioButton>())
                    {
                        i++;
                        if (rb.Checked)
                        {
                            PlaceIcon(rb, false);
                        }
                        if (i == Int32.Parse(TrimPrefix(LoadedQuizData.answers[index])))
                        {
                            PlaceIcon(rb, true);
                        }
                    }

                }
            }
            else
            {
                answerBox.Enabled = false;
                if (answerBox.Text.ToLower() == correctAnswer)
                {
                    CorrectAnswerProcedure();
                }
                else
                {
                    IncorrectAnswerProcedure();
                }
            }
            btnNextQuestion.Enabled = true;
        }
        private void PlaceIcon(RadioButton rb, bool correct) //Places either a tick or cross next to a radio button.
        {
            if (correct)
            {
                Label tick = new Label();
                tick.Location = new Point(rb.Right + 5, rb.Top + 2);
                tick.Text += "✅";
                tick.ForeColor = Color.Green;
                panel1.Controls.Add(tick);
            }
            else
            {
                Label cross = new Label();
                cross.Location = new Point(rb.Right + 5, rb.Top + 2);
                cross.Text = "❌";
                cross.ForeColor = Color.Red;
                panel1.Controls.Add(cross);
            }
        }
        private void CorrectAnswerProcedure() //Procedure for when an answer is correct
        {
            correctAnswers++;
            lblCorrectAnswerCount.Text = $"Correct: {correctAnswers}";
            lblAnswerStatus.ForeColor = Color.Green;
            lblAnswerStatus.Text = "Correct!";
        }
        private void IncorrectAnswerProcedure() //Procedure for an incorrect answer
        {
            incorrectAnswers++;
            lbl_IncorrectAnswerCount.Text = $"Incorrect: {incorrectAnswers}";
            lblAnswerStatus.Text = $"Incorrect! The answer is {TrimPrefix(LoadedQuizData.answers[index])}";
        }
        private void btnNextQuestion_Click(object sender, EventArgs e) //The next question is loaded, unless the current question is the last
        {
            if (btnNextQuestion.Text == "End Quiz")
            {
                EndQuiz();
            }
            else
            {
                LoadQuestion();
            }
        }
        private void btnAbortQuiz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the quiz?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                EndQuiz();
            }
        }
        private void EndQuiz() //Proceeds to the end screen
        {
            EndScreen endScreen = new EndScreen();
            endScreen.Show();
            this.Hide();
        }
        private void Application_Close(object sender, FormClosedEventArgs e) //Close button exits the program
        {
            Application.Exit();
        }
    }
        
}
