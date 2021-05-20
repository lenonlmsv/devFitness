using System;

namespace _01_console
{
    class ConsoleApp
    {
        static void Main()
        {
            UserData data = new UserData();
            data.Name = GetStringAnswer("Type your name:");
            data.Job = GetStringAnswer("Type your job:");
            data.Age = GetIntAnswer("Type your age:");
            string message = ReturnMessage(data.Name);
            Console.WriteLine(message);

            ConsoleApp log = new ConsoleApp();

            log.WriteLog(data.Name);
        } // End Main

        static void Break() {
            while (true){
                Console.WriteLine("Type anything");
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s)){
                    break;
                }

                Console.WriteLine(s);
            }
        } //End Break

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

            string answer;
            do 
            {
                answer = GetInput();
            } while (string.IsNullOrEmpty(answer));
            
            return answer;

            string GetInput() 
            {
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                return answer;
            } //End GetInput
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

        public void WriteLog(string args) {
            using (System.IO.TextWriter log = System.IO.File.CreateText($"{args}.txt")) {
                log.Write(args);
            }

            return;
        } //End WriteLog

        public class UserData {
            public UserData() {}

            public UserData(string strName, string strJob, int intAge) {
                Name = strName;
                Job = strJob;
                Age = intAge;
            } //End UserData method

            public string Name;
            public string Job;
            public int Age;

        }// End UserData

    } //End ConsoleApp
}
