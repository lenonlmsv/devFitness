using System;

namespace devFitness_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string name = Console.ReadLine();

            Console.WriteLine("Digite sua altura");
            string heigth = Console.ReadLine();

            Console.WriteLine("Digite seu peso");
            string weight = Console.ReadLine();
            
            showOptions();

            string option = Console.ReadLine();

            if(option == "1") {
                Console.WriteLine($"Nome: {name}, Altura: {heigth}, Peso: {weight}");
            }

            else if (option == "2") {
                //Register(new List<Meal>);
            }

            else if (option == "3") {
                //ShowMeals();
            }

            else {

            }
        } //Main

        public static void showOptions() {
            Console.WriteLine("--- Bem-vindo (a) ao devFitness ---");
            Console.WriteLine("1 - Exibir detalhes de usuário");
            Console.WriteLine("2 - Cadastrar nova refeição");
            Console.WriteLine("3 - Listar todas as refeições do dia");
            Console.WriteLine("4 - Encerrar aplicação");
        } //showOptions

        public static void Register() {

        }

        public static void ShowMeals() {
            
        }
    }
}
