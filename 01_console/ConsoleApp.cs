using System;

namespace _01_console
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            string name = GetStringAnswer("Type your name:");
            string job = GetStringAnswer("Type your job:");
            int age = GetIntAnswer("Type your age:");
            string message = ReturnMessage(name);
            Console.WriteLine(message);
        } // End Main

        static string ReturnMessage(string name)
        {
            string message = $"Hello World, {name}!";
            return message;
        } //End ReturnHelloWorld  

        public static string GetStringAnswer(string question)
        {
            if(string.IsNullOrEmpty(question))
            {
                LauchException("");
            } //End if

            string GetInput() 
            {
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                return answer;
            } //End GetInput

            string answer = GetInput();
            while (string.IsNullOrEmpty(answer))
            {
                answer = GetInput();
            } //End while

            return answer;
        } //End GetName

        public static int GetIntAnswer(string question)
        {
            if (string.IsNullOrEmpty(question))
            {
                LauchException("");
            } //End if

            int GetInput()
            {
                Console.WriteLine(question);
                int answer = Convert.ToInt32(Console.ReadLine());
                return answer;
            } //End GetInput

            int answer = GetInput();
            while (answer < 18)
            {
                LauchException("At least 18 Y.O!");
            } //End while

            return answer;
        }

        static string LauchException(string message)
        {
            if (string.IsNullOrEmpty(message))
            { //End if
                throw new ArgumentException("An Exception Occurs!");
            }
            else
            {
                throw new ArgumentException(message);
            } //End else
        } //End LauchException
    }
}
