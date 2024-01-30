using System;

public class TicTacTools
{

	char[] tester = new char[] { 'X', ' ', 'O', 'O', 'X', ' ', ' ', 'O', 'X' };

	static string printBoard(char[] array)
	{
		//System.Text.StringBuilder sb = new System.Text.StringBuilder();
		string board = "";

		//foreach (var item in array)
		//{
		//   sb.Append(item.ToString());
		// sb.Append(item.ToString() + ", ");
		//}

		for (int x = 0; x < 9, x++)
		{

			board += array[x];

			if (x == 2 || x == 5)
			{

				board += "\n";
			}
			else
			{
				board += " ";
			}
		}

		return board.ToString();
	}
}

print(printBoard(tester));

// testing

