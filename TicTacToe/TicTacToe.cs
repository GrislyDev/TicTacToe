using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
	class TicTacToe
	{
		// Initialization of variables
		const char SIGN_X = 'x';
		const char SIGN_O = 'o';
		const char SIGN_EMPTY = '.';
		const char SIGN_GRID = ' ';
		char[,] table;
		bool isPlaying;
		int counter;

		Random random;
		DisplayScreen displayScreen;

		public TicTacToe() // Constructor
		{
			displayScreen = new DisplayScreen();
			random = new Random();
			table = new char[5, 5];
		}

		public void Game()
		{
			while (isPlaying)
			{
				Control();
				Check(new string("Player"), SIGN_X);
				AI();
				Check(new string("Computer"), SIGN_O);
			}
		}

		public void Menu(string msg)
		{
			isPlaying = false;
			counter = 0;
			table = new char[5, 5];
			displayScreen.printTable(table, (0, 0), msg);

			Console.SetCursorPosition((Console.WindowWidth / 2 - 11), 12);
			Console.WriteLine("PRESS ANY KEY TO START");
			Console.ReadKey();
			isPlaying = true;
			InitTable(); // Create new table
			while (isPlaying)
			{
				Control();
				Check(new string("Player"), SIGN_X);
				AI();
				Check(new string("Computer"), SIGN_O);
			}
		}

		void Control()
		{
			var cursorPosition = (X: 0, Y: 0);
			displayScreen.printTable(table, cursorPosition, new string("I am your fan!"));

			while (true)
			{
				ConsoleKeyInfo pressed = Console.ReadKey(true);
				if (pressed.Key == ConsoleKey.LeftArrow)
				{
					if (cursorPosition.Y - 2 >= 0)
					{
						cursorPosition.Y -= 2;
						displayScreen.printTable(table, cursorPosition, new string("I am your fan!"));
					}
				}
				if (pressed.Key == ConsoleKey.UpArrow)
				{
					if (cursorPosition.X - 2 >= 0)
					{
						cursorPosition.X -= 2;
						displayScreen.printTable(table, cursorPosition, new string("I am your fan!"));
					}
				}
				if (pressed.Key == ConsoleKey.RightArrow)
				{
					if (cursorPosition.Y + 2 <= 5)
					{
						cursorPosition.Y += 2;
						displayScreen.printTable(table, cursorPosition, new string("I am your fan!"));
					}
				}
				if (pressed.Key == ConsoleKey.DownArrow)
				{
					if (cursorPosition.X + 2 <= 5)
					{
						cursorPosition.X += 2;
						displayScreen.printTable(table, cursorPosition, new string("I am your fan!"));
					}
				}
				if (pressed.Key == ConsoleKey.Enter)
				{
					if (table[cursorPosition.X, cursorPosition.Y] == SIGN_EMPTY)
					{
						table[cursorPosition.X, cursorPosition.Y] = SIGN_X;
						displayScreen.printTable(table, cursorPosition, new string("I am your fan!"));
						return;
					}
				}
			}
		}

		void AI()
		{
			while (true)
			{
				int x, y;
				x = random.Next(0, 5);
				y = random.Next(0, 5);
				if (table[x, y] == SIGN_EMPTY)
				{
					table[x, y] = SIGN_O;
					return;
				}

			}
		}

		void Check(string player, char sign)
		{
			counter++;
			//Horizontal
			if (table[0, 0] == sign && table[2, 0] == sign && table[4, 0] == sign)
				Menu(new string(player + " won!"));
			if (table[0, 2] == sign && table[2, 2] == sign && table[4, 2] == sign)
				Menu(new string(player + " won!"));
			if (table[0, 4] == sign && table[2, 4] == sign && table[4, 4] == sign)
				Menu(new string(player + " won!"));
			//Vertical
			if (table[0, 0] == sign && table[0, 2] == sign && table[0, 4] == sign)
				Menu(new string(player + " won!"));
			if (table[2, 0] == sign && table[2, 2] == sign && table[2, 4] == sign)
				Menu(new string(player + " won!"));
			if (table[4, 0] == sign && table[4, 2] == sign && table[4, 4] == sign)
				Menu(new string(player + " won!"));
			//Diagonal
			if (table[0, 0] == sign && table[2, 2] == sign && table[4, 4] == sign)
				Menu(new string(player + " won!"));
			if (table[4, 0] == sign && table[2, 2] == sign && table[0, 4] == sign)
				Menu(new string(player + " won!"));
			if (counter == 9)
				Menu(new string("Tie!"));
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
}
