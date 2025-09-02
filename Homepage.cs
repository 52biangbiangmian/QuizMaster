using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizMaster
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            
        }
        public static bool randomised; // Determines if the quiz directory follows the file or randomises the questions.
        private void Homepage_Load(object sender, EventArgs e) 
        {
            LoadedQuizData.Reset();
            randomised = false;
            lblBounds.Text = string.Empty; //The text for the bounds of the number selector does not appear until a file is selected
            lblDocumentPath.Text = GetDefaultPath(); //The default directory (.\QuizData) is checked upon loading of the form
            PopulateComboBox(GetDefaultPath());
        }
        private void btnCancel_Click(object sender, EventArgs e) //Cancel button exits the program
        {
            Application.Exit();
        }
        private string GetDefaultPath() //Automatically selects a default directory if it exists (.\QuizData)
        {
            string currentPath = Directory.GetCurrentDirectory() + @"\QuizData";
            DirectoryInfo directoryInfo = new DirectoryInfo(currentPath);
            if (directoryInfo.Exists)
            {
                return currentPath;
            }
            else
            {
                return "No directory currently selected.";
            }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e) //When the Select Directory button is clicked, the folder browser dialog is opened for the user to select a directory.
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblDocumentPath.Text = folderBrowserDialog1.SelectedPath;
                PopulateComboBox(folderBrowserDialog1.SelectedPath); //The combo box is populated with .qff files if a directory with .qff files is selected.
            }  
        }
        private void PopulateComboBox(string path)  //Populates the combo box with .qff files
        {
            QuestionNumSelector.Enabled = false; //Numeric up-down selector is disabled
            dropDownFileSelection.Enabled = false; //Combo box is disabled
            btnStartQuiz.Enabled = false; //Start quiz button is disabled
            dropDownFileSelection.Items.Clear();
            dropDownFileSelection.SelectedItem = null;
            dropDownFileSelection.Text = string.Empty; //The combo box is cleared, in case there were previous items.

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists) //Returns if directory does not exist
            {
                return;
            }

            FileInfo[] fileInfos = directoryInfo.GetFiles("*.qff");

            if (fileInfos.Length > 0) //If a folder with files ending in .qff is selected, the combo box is enabled and they are added to it.
            {
                dropDownFileSelection.Enabled = true;
                dropDownFileSelection.Text = "Select quiz...";
                foreach (FileInfo fileInfo in fileInfos)
                {
                    dropDownFileSelection.Items.Add(fileInfo.Name.Remove(fileInfo.Name.Length - 4, 4)); //Removes .qff from the displayed combo box item
                }
            }
            else
            {
                MessageBox.Show("Please select a folder with .qff files.");
            }     
        }
        private void dropDownFileSelection_SelectedIndexChanged(object sender, EventArgs e) //ParseFile() is run on the selected file
        {
            ParseFile(lblDocumentPath.Text + "\\" + (string)dropDownFileSelection.SelectedItem + ".qff");
        }
        private void ParseFile(string file) //The selected file is parsed
        {
            LoadedQuizData.Reset();
            lblBounds.Text = string.Empty;
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists) //Returns if file does not exist
            {
                return;
            }
            string fileLine;
            bool answerPresence = true;
            bool questionPresence = false;
            List<string> choices = new List<string>();
            int totalQuestions = 0;
            StreamReader quizFile = new StreamReader(file);
            fileLine = quizFile.ReadLine();

            while (fileLine != null) //Selected file is parsed into separate lists of questions, answers, and choices 
            {
                fileLine = fileLine.Trim();
                if (fileLine.StartsWith("Question:"))
                {
                    if (!answerPresence) //Questions with no answer are removed from the list
                    {
                        choices.Clear();
                        LoadedQuizData.questions.RemoveAt(LoadedQuizData.questions.Count - 1);
                    }
                    LoadedQuizData.questions.Add(fileLine);
                    questionPresence = true;
                    answerPresence = false;
                }
                else if (fileLine.StartsWith("Choice:") && questionPresence) //Such lines are ignored between an answer line and a question line
                {
                    choices.Add(fileLine);
                }
                else if (fileLine.StartsWith("Answer:") && questionPresence) //Such lines are ignored between an answer line and a question line
                {
                    LoadedQuizData.answers.Add(fileLine);
                    LoadedQuizData.choices.Add(choices.ToArray());
                    //OutputQuizData(totalQuestions);
                    choices.Clear();
                    totalQuestions++;
                    answerPresence = true;
                    questionPresence = false;
                }
                fileLine = quizFile.ReadLine();
            }
            quizFile.Close();

            if (totalQuestions > 0)
            {
                QuestionNumSelector.Enabled = true; //Enables the selector for the number of questions
                QuestionNumSelector.Minimum = 1;
                QuestionNumSelector.Maximum = totalQuestions;
                lblBounds.Text = $"(1 - {totalQuestions})";
                btnStartQuiz.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a correctly formatted file."); //Displays if the user selects a file with no valid questions
            }
        }
        private void OutputQuizData(int index) //The quiz data is outputted on console.
        {
            Console.WriteLine("");
            Console.WriteLine(LoadedQuizData.questions[index]);
            foreach (string choice in LoadedQuizData.choices[index])
            {
                Console.WriteLine(choice);
            }
            Console.WriteLine(LoadedQuizData.answers[index]);
            Console.WriteLine("");
        }
        private void RandomiseQuestionNumbers(int count, int maximum) //Generates the unique random numbers and stores it in the hash set
        {
            LoadedQuizData.questionNumbers.Clear();
            Random r = new Random();
            while (LoadedQuizData.questionNumbers.Count < count)
            {
                LoadedQuizData.questionNumbers.Add(r.Next(0, maximum));
            }
            //OutputRandomIndices();
        }
        private void OutputRandomIndices() //Displays the contents of LoadedQuizData.questionNumbers to console
        {
            Console.WriteLine("");
            int j = 0;
            foreach (int i in LoadedQuizData.questionNumbers)
            {
                j++;
                Console.WriteLine($"{j}: {i} ");
            }
            Console.WriteLine("");
        }
        private void btnStartQuiz_Click(object sender, EventArgs e) //Sets random numbers and opens the QuestionPage form
        {
            LoadedQuizData.questionCount = (int)QuestionNumSelector.Value;
            if (checkBoxRandomise.Checked ) //If the user ticks the "Randomise" checkbox, random indices will be generated to randomly select corresponding items from the lists
            {
                randomised = true;
                RandomiseQuestionNumbers(LoadedQuizData.questionCount, LoadedQuizData.questions.Count);
            }
            //OutputLoadedQuizData(randomised, LoadedQuizData.questionCount);
            QuestionPage questionPage = new QuestionPage();
            questionPage.Show();
            this.Hide();
        }
        private void OutputLoadedQuizData(bool random, int length) // Displays the loaded questions, their answers, and choices in console
        {
            int j = 0;
            Console.WriteLine("");
            if (random)
            {
                foreach (int i in LoadedQuizData.questionNumbers) //If random, the randomised questions are displayed
                {
                    j++;
                    Console.WriteLine(j + "\n" + LoadedQuizData.questions[i]);
                    foreach (string choice in LoadedQuizData.choices[i])
                    {
                        Console.WriteLine(choice);
                    }
                    Console.WriteLine(LoadedQuizData.answers[i]);
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < length; i++) //Otherwise they are displayed in order
                {
                    j++;
                    Console.WriteLine(j + "\n" + LoadedQuizData.questions[i]);
                    foreach (string choice in LoadedQuizData.choices[i])
                    {
                        Console.WriteLine(choice);
                    }
                    Console.WriteLine(LoadedQuizData.answers[i]);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("");
        }
        private void Application_Close(object sender, FormClosedEventArgs e) //Close button exits the program
        {
            Application.Exit();
        }

    }
}
