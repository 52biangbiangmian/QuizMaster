using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaster
{
    public static partial class LoadedQuizData
    {
        public static List<string> questions = new List<string>(); //A list containing all questions
        public static List<string> answers = new List<string>(); //A list containing all respective answers
        public static HashSet<int> questionNumbers = new HashSet<int>(); //A hash set of non-duplicate random numbers, these are used to (randomly) determine the indices for the question and answer lists 
        public static int questionCount; //Total number of questions selected by the user.
        public static List<string[]> choices = new List<string[]>(); //A list of arrays, containing respective choices for multiple choice questions
        public static void Reset()
        {
            questions = new List<string>(); 
            answers = new List<string>(); 
            questionNumbers = new HashSet<int>(); 
            choices = new List<string[]>();
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homepage());
        }
    }
}
