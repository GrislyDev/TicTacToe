using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
	class DisplayScreen
	{

		public void printTable(char[,] table, (int X, int Y) curPos, string msg) // Display playing field
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

			{
				Console.SetCursorPosition(0, 20);
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("  =====  ");
				Console.WriteLine("=========");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("( o _ o )");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(" /|   |\\");
				Console.WriteLine("  |___|");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("  /   \\ ");
				Console.SetCursorPosition(20, 23);
				Console.WriteLine(msg);
			}// STASIK

		}

	}
}
