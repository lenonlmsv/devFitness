using System;

namespace _03_review
{
    class StudentsInfo
    {
        public static Student[] students = new Student[10];
        public static int studentsIndex = 0;
        static void Main(string[] args)
        {
            Run();
        } //End Main
        private static void Run() {
                string userInput;

                do {
                    userInput = GetAnswer();
                } while (string.IsNullOrEmpty(userInput));

                userInput = userInput.ToUpper();

                switch (userInput) {
                    case "1" :
                        var student = SetStudent();
                        students[studentsIndex] = student;
                        studentsIndex ++;
                        Run();
                        break;
                
                    case "2" :
                        foreach(var s in students) {
                            if(!string.IsNullOrEmpty(s.Name)) {
                                Console.WriteLine($"Aluno: {s.Name} - Nota {s.Grade}");
                            } 
                        }
                        Run();
                        break;
                    case "3" :
                        Console.WriteLine($"A média das notas é {GetGradesAverage()}");
                        Run();
                        break;
                    case "X" :
                        break;
                    default :
                        Run();
                        break;
                } //End switch
        } //End Run

        private static decimal GetGradesAverage() {
            decimal totalGrade = 0;
            int count = 0;
            foreach (var s in students) {
                if(!string.IsNullOrEmpty(s.Name)) {
                    totalGrade += s.Grade;
                    count ++;
                }
            }

            decimal average = totalGrade/count;
            return average;
        }

        private static Student SetStudent() {
            Student student = new Student();
            
            string name;
            decimal grade; //strGrade = decimal.Parse(Console.ReadLine);

            do {
                Console.WriteLine("Type the new student name:");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));
            
            do {
                Console.WriteLine("Type the new student grade (0 a 10):");
                grade = decimal.Parse(Console.ReadLine());
            } while (grade < 0 || grade > 10); //string.IsNullOrEmpty(grade));

            student.Name = name;
            student.Grade = grade;

            return student;
        } //End SetStudent

        private static string GetAnswer() {
            string userInput;
            do {
                userInput = SetOptions();
            } while (string.IsNullOrEmpty(userInput));

            if(userInput.ToUpper() == "X") {
                //break;
            }
            return userInput;
        } //End GetAnswer

        private static string SetOptions() {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Inserir Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular Medias");
            Console.WriteLine("X - Sair");
            string userOption = Console.ReadLine();
            return userOption;
        } //End getUserInput

    } // End class StudentsInfo

}
