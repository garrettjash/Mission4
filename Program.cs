// Mission 4 - TicTacToe
// Group 2-2
// Garrett Ashcroft, Caroline Tobler, Jared Rosenlund, Vivian Solgere

using System.Reflection.Metadata.Ecma335;

TicTacTools tt = new TicTacTools();

bool cont = false;
bool playAgain = true;
bool winner = false;
int position = 0;
char turn = 'X';
char checkWin = ' ';
string again = "";
string board = "";
string input = "";

Console.WriteLine("Welcome to TicTacToe!");
Console.WriteLine("Game Rules: Pick a side, X's or O's. On your turn, enter the number with the corresponding position on the board below:");
// Add code to show the user the board layout 

char[] gameBoard = new char[9];
gameBoard = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
Console.WriteLine(tt.printBoard(gameBoard));
Console.WriteLine();
Console.WriteLine("======================");

while (playAgain == true)
{
    // start with cont as false
    cont = false;

    // Clear game board
    gameBoard = [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '];
    Console.WriteLine();
    Console.WriteLine("New game!!");
    Console.WriteLine();
    Console.WriteLine(tt.printBoard(gameBoard));

    // Keep playing while there is no winner
    while (winner == false)
    {
        // Determine whose turn it is
        if (turn.Equals('X'))
        {
            Console.WriteLine("X's Turn!");
        }
        else
        {
            Console.WriteLine("O's Turn!");
        }

        // Let user choose which space to put their mark in
        Console.WriteLine("Choose which spot to put your mark in (1-9):");
        input = Console.ReadLine();

        //Error handling!!
        
        while (cont == false)
        {
            // Check that input is an int
            if (int.TryParse(input, out position))
            {
                // Make sure position is an int between 1 and 9
                if (position >= 1 && position <= 9)
                {
                    // Make sure space isn't full
                    if (gameBoard[position - 1] == ' ')
                    {
                        cont = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that space is full. Please pick a different one:");
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please provide a number between 1 and 9:");
                    input = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Please provide a number between 1 and 9:");
                input = Console.ReadLine();
            }
        }

        cont = false;

        // Update array and pass it to printBoard
        gameBoard[position - 1] = turn;

        // Switch Turns
        if (turn.Equals('X'))
        {
            turn = 'O';
        }
        else
        {
            turn = 'X';
        }

        board = tt.printBoard(gameBoard);

        Console.WriteLine(tt.printBoard(gameBoard));

        checkWin = tt.CheckWinner(gameBoard);

        // Check for a winner
        if (checkWin.Equals('N'))
        {
            // No winner yet, just keep going
        }
        else if (checkWin.Equals('T'))
        {
            // Tie!
            winner = true;

            Console.WriteLine("Game over! It's a tie!");
        }
        else if (checkWin.Equals('X') || checkWin.Equals('O'))
        {
            // Somebody won!
            winner = true;

            Console.WriteLine("Game over, " + checkWin + "'s won!");
        }
    }

    // Ask if they want to play again
    Console.WriteLine("Do you want to play again? y/n:");
    again = Console.ReadLine();

    // handle responses other than y/n
    while (cont == false)
    {
        if (again.Equals("n"))
        {
            playAgain = false;
            cont = true;
        }
        else if (again.Equals("y"))
        {
            winner = false;
            cont = true;
        }
        else
        {
            Console.WriteLine("Please enter a y or n");
            again = Console.ReadLine();
        }
    }
}

Console.WriteLine("Thank you for playing! Come again soon!");