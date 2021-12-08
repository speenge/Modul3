using System;

namespace SpørreBonanzaV2
{
    class Program
    {
        static private string[] questions = new string[4];
        static private string[] feedback = new string[4];
        static private string[] answers = new string[4];
        static private string[] altfeedback = new string[4];
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Welcome, Answer these questions!");
            Console.WriteLine("*************************************");


            questions[0] = "Do you like programming?";
            questions[1] = "Do you play games?";
            questions[2] = "Do you exercise?";
            questions[3] = "Do you eat fish?";

            feedback[0] = "Programming is fun";
            feedback[1] = "Games are fun";
            feedback[2] = "Exercise is important";
            feedback[3] = "Fish is healthy";

            altfeedback[0] = "You should Programm";
            altfeedback[1] = "You should Game";
            altfeedback[2] = "You should Exercise";
            altfeedback[3] = "You should eat Fish";


            for (int i = 0, x = questions.Length; i < x; i++)
            {
                string a;
                AskQuestion(questions[i], i);
                if (answers[i] == "Y" || answers[i] == "YES")
                {
                    a = feedback[i];
                }
                else a = altfeedback[i];
                AnswerQuestion(a, i);

            }

            foreach (var answer in answers)
            {
                Console.WriteLine(answer);
            }
        }
            

            
        static void AskQuestion(string question, int i)
        {
            Console.WriteLine(question);
            answers[i] = Console.ReadLine().ToUpper();
        }

        static void AnswerQuestion(string svarene, int i)
        {
            Console.WriteLine(svarene);
        }

    }
}