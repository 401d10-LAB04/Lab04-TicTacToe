using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Game myGame = new Game(player1, player2);
            Player Winner = myGame.Play();
            if(Winner != null)
            {
                Console.WriteLine($"Congratulations, {Winner.Name}, you actually won at Tic Tac Toe!");
            }
            else
            {
                Console.WriteLine($"Oh no! A draw!");
            }
        }
    }
}
