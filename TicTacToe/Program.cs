using System;

namespace TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			// Enter
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

		TicTacToe() // Constructor
		{
			random = new Random();
			table = new char[3,3];
		}

		void Game() // Game logic
		{
			InitTable(); // Create new table

			while (true)
			{
				// Human turn
				// Check pos
				// AI turn
				// Check pos
			}
		}

		void PrintTable() // Display playing field
		{
			
		}

		void InitTable() // Initialization of table
		{
			
		}
	}
}
