using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTests
{
    public class UnitTest1
    {
        
        
        [Fact]
        public void TestCheckForWinnerCorrectlyReturnsTrueForWonGame()
        {
            //Arrange
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2); // Creates a new game for testing, to which we will set the board
            string[,] winningBoard = new string[,]
                {
                    {"X", "2", "3"},
                    {"4", "X", "6"},
                    {"7", "8", "X"},
                };
            testGame.Board.GameBoard = winningBoard;

            //Act
            bool win = testGame.CheckForWinner(testGame.Board);

            //Assert
            Assert.True(win);
        }

        [Fact]
        public void TestCheckForWinnerCorrectlyReturnsFalseForNotWonGame()
        {
            //Arrange
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2); // Creates a new game for testing, to which we will set the board
            string[,] noWinBoard = new string[,]
            {
                {"X", "2", "3"},
                {"4", "X", "6"},
                {"7", "8", "9"},
            };
            testGame.Board.GameBoard = noWinBoard;

            //Act
            bool win = testGame.CheckForWinner(testGame.Board);

            //Assert
            Assert.False(win);
        }

        [Fact]
        public void TestSwitchPlayersCorrectlySwitchesPlayers()
        {
            //Arrange
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2); // Creates a new game for testing, within which we will switch players
            testGame.PlayerOne.IsTurn = true;

            //Act
            testGame.SwitchPlayer();

            //Assert
            Assert.True(testGame.PlayerTwo.IsTurn);
        }

        [Fact]
        public void TestBoardNumberCorrespondsCorrectlyWithPosition()
        {
            //Arrange
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2); // Creates a new game for testing, within which we will try to match numbers to positions
            int testInputNumber = 6;
            Position correctPosition = new Position(1, 2);
            string correctPositionString = $"{correctPosition.Row}, {correctPosition.Column}";

            //Act
            Position testPosition = Player.PositionForNumber(testInputNumber);
            string testPositionString = $"{testPosition.Row}, {testPosition.Column}";

            //Assert
            Assert.Equal(correctPositionString, testPositionString);
        }

        [Fact]
        public void TestPlayersHaveCorrectMarkers()
        {
            //Arrange
            Player player1 = new Player();
            Player player2 = new Player();

            //Act
            Game testGame = new Game(player1, player2);

            //Assert
            Assert.Equal("X", testGame.PlayerOne.Marker);

        }
    }
}
