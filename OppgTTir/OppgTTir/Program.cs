using System;

namespace OppgTTir
{
    class Program
    {
        static void Main(string[] args)
        {
            string predefined = "Dette er oppgaven til første time";
            string userInput = "";  //(dette er en tom string).
            userInput = Console.ReadLine();
            Console.WriteLine($"predefined: {predefined} | userInput: {userInput} |");
        }
    }
}
