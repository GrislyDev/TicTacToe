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
		const char SIGN_GRID = ' ';
		char[,] table;

		Random random;
		DisplayScreen displayScreen;

		public TicTacToe() // Constructor
		{
			displayScreen = new DisplayScreen();
			random = new Random();
			table = new char[5, 5];
		}

		public void Game() // Game logic
		{
			var cursorPosition = (X: 0, Y: 0);
			InitTable(); // Create new table
			displayScreen.PrintTable(table,cursorPosition);
			while (true)
			{
				// Human turn
				while (true) // Control
				{
					ConsoleKeyInfo pressed = Console.ReadKey(true);
					if (pressed.Key == ConsoleKey.LeftArrow)
					{
						if (cursorPosition.Y - 2 >= 0)
						{
							cursorPosition.Y -= 2;
							displayScreen.PrintTable(table, cursorPosition);
						}
					}
					if (pressed.Key == ConsoleKey.UpArrow)
					{
						if (cursorPosition.X - 2 >= 0)
						{
							cursorPosition.X -= 2;
							displayScreen.PrintTable(table, cursorPosition);
						}
					}
					if (pressed.Key == ConsoleKey.RightArrow)
					{
						if (cursorPosition.Y + 2 <= 5)
						{
							cursorPosition.Y += 2;
							displayScreen.PrintTable(table, cursorPosition);
						}
					}
					if (pressed.Key == ConsoleKey.DownArrow)
					{
						if (cursorPosition.X + 2 <= 5)
						{
							cursorPosition.X += 2;
							displayScreen.PrintTable(table, cursorPosition);
						}
					}
					if (pressed.Key == ConsoleKey.Enter)
					{
						if (table[cursorPosition.X, cursorPosition.Y] == '.')
						{
							table[cursorPosition.X, cursorPosition.Y] = 'X';
							displayScreen.PrintTable(table, cursorPosition);
						}
					}
				}
				// Check
				// AI turn
				// Check
			}
		}

		public void InitTable() // Initialization of table
		{
			for (int row = 0; row < 5; row++)
				for (int col = 0; col < 5; col++)
				{
					if (row % 2 == 0 && col % 2 == 0)
						table[row, col] = SIGN_EMPTY;
					else
						table[row, col] = SIGN_GRID;
				}
		}
	}
	class DisplayScreen
	{

		public void PrintTable(char[,] table, (int X,int Y) curPos) // Display playing field
		{
			Console.Clear();
			int centerX = (Console.WindowWidth / 2) - 2;
			int centerY = (Console.WindowHeight / 2) - 3;

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition((Console.WindowWidth / 2 - 10), 0);
			Console.WriteLine("RULES FOR TIC-TAC-TOE");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition((Console.WindowWidth / 2 - 22), 2);
			Console.WriteLine("1. The game is played on a grid that's 3 by 3");
			Console.SetCursorPosition((Console.WindowWidth / 2 - 38), 3);
			Console.WriteLine("2. You - X, computer - 0. Players take turns putting their marks on empty spaces.");
			Console.SetCursorPosition((Console.WindowWidth / 2 - 49), 4);
			Console.WriteLine("3. The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner.");
			Console.SetCursorPosition((Console.WindowWidth / 2 - 54), 5);
			Console.WriteLine("4. When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie.");
			Console.ResetColor();

			for (int row = 0; row < 5; row++)
			{
				Console.SetCursorPosition(centerX, centerY++);
				for (int col = 0; col < 5; col++)
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
			}

		}

	}
}
