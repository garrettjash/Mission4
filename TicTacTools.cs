using System;

public class TicTacTools
{
	public static char[] tester = new char[] { 'X', ' ', 'O', 'O', 'X', ' ', ' ', 'O', 'X' };

	public static string printBoard(char[] board)
	{
		var stringBuilder = new System.Text.StringBuilder();

		for (int i = 0; i < board.Length; i++)
		{
			stringBuilder.Append(board[i]);
			if ((i + 1) % 3 == 0)
			{
				if (i < board.Length - 1)
				{
					stringBuilder.AppendLine();
					stringBuilder.AppendLine("-----");
				}
			}
			else
			{
				stringBuilder.Append(" | ");
			}
		}

		return stringBuilder.ToString();
	}


	public static char CheckWinner(char[] board)
	{
		// Winning combinations: rows, columns, diagonals
		int[,] winningCombinations = new int[,]
		{
			{0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Rows
			{0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Columns
			{0, 4, 8}, {2, 4, 6}             // Diagonals
		};

		for (int i = 0; i < winningCombinations.GetLength(0); i++)
		{
			if (board[winningCombinations[i, 0]] != ' ' &&
				board[winningCombinations[i, 0]] == board[winningCombinations[i, 1]] &&
				board[winningCombinations[i, 1]] == board[winningCombinations[i, 2]])
			{
				return board[winningCombinations[i, 0]];
			}
		}

		// Check for tie
		if (Array.IndexOf(board, ' ') == -1)
		{
			return 'T';
		}

		// No winner yet
		return 'N';
	}

}

