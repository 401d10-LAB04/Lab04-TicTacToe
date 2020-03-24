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
        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
        // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
    }
}
