using System;

namespace TicTacToe
{
	class Program
	{

		static void Main(string[] args)
		{
			// Enter
			TicTacToe tictactoe = new TicTacToe();

			tictactoe.Game();

		}
	}
	class TicTacToe
	{
		// Initialization of variables
		const char SIGN_X = 'x';
		const char SIGN_O = 'o';
		const char SIGN_EMPTY = '.';
		char[,] table;

		Random random;
		DisplayScreen displayScreen;

		public TicTacToe() // Constructor
		{
			displayScreen = new DisplayScreen();
			random = new Random();
			table = new char[3, 3];
		}

		public void Game() // Game logic
		{
			InitTable(); // Create new table
			displayScreen.PrintTable(table,Control());
			//while (true)
			//{
			//	// Human turn
			//	// Check pos
			//	// AI turn
			//	// Check pos
			//}
		}

		(int, int) Control()
		{
			var cursorPosition = (X: 0, Y: 0);

			return cursorPosition;

		}
		public void InitTable() // Initialization of table
		{
			for (int row = 0; row < 3; row++)
				for (int col = 0; col < 3; col++)
					table[row, col] = SIGN_EMPTY;
		}
	}
	class DisplayScreen
	{

		public void PrintTable(char[,] table, (int X,int Y) curPos) // Display playing field
		{


			for (int row = 0; row < 3; row++)
			{

				for (int col = 0; col < 3; col++)
				{
					if (row == curPos.X && col == curPos.Y)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write(table[row, col] + " ");
						Console.ResetColor();
					}
					else
					{
						Console.Write(table[row, col] + " ");
					}
				}
				Console.WriteLine();
			}

		}

	}
}
