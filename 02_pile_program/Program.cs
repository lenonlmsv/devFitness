using System;
using _02_pile_program.classes;

namespace _02_pile_program
{
    class Program
    {
        static void Main()
        {
            var pile = new Pile();
            pile.AddToPile(1);
            pile.AddToPile(10);
            pile.AddToPile(30);
            pile.AddToPile(40);
            pile.AddToPile(50);

            Console.WriteLine(pile.RemoveFromPile());
        } //End Main

    } //End Program

}//End namespace _02_pile_program

