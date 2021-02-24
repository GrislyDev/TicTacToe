using System;

namespace TicTacToe
{
	class Program
	{

		static void Main(string[] args)
		{
			// Enter
			TicTacToe tictactoe = new TicTacToe();

			tictactoe.Game(new string("Arrow keys for control. Enter for select."));

		}
	}
}
