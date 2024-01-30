// Mission 4 - TicTacToe
// Group 2-2
// Garrett Ashcroft, Caroline Tobler, Jared Rosenlund, Vivian Solgere


/* methods:
public string printBoard(array)
public string checkWinner(array)

The “Driver” class (the Program.cs class with the main method where the program begins) will: 
    • Welcome the user to the game 
    • Create a game board array to store the players’ choices 
    • Ask each player in turn for their choice and update the game board array 
    • Print the board by calling the method in the supporting class 
    • Check for a winner by calling the method in the supporting class, 
    and notify the players when a win has occurred and which player won the game 
*/
TicTacTools tt = new TicTacTools();

bool playAgain = true;
bool winner = false;
int position = 0;
char turn = 'X';
string checkWin = "";
string again = "";
string board = "";


Console.WriteLine("Welcome to TicTacToe!");
// Add code to show the user the board layout 

char[] gameBoard = [];

do
{
    // Clear game board
    gameBoard = [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '];
    Console.WriteLine("New game!!");
    Console.WriteLine();
    Console.WriteLine(tt.printBoard(gameBoard));

    // Keep playing while there is no winner
    while (winner == false);
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
        position = int.Parse(Console.ReadLine());

        // Add error handling and stuff

        // Update array and pass it to printBoard
        gameBoard[position - 1] = turn;

        board = tt.printBoard(gameBoard);

        Console.WriteLine(tt.printBoard(gameBoard));

        checkWin = tt.checkWinner(gameBoard);

        // Check for a winner
        if (checkWin.Equals("None"))
        {
            // No winner yet, just keep going
        }
        else
        {
            // Somebody won!
            winner = true;

            Console.WriteLine("Game over, " + checkWin + "'s won!");
        }
    }

    // Ask if they want to play again
    Console.WriteLine("Do you want to play again? y/n:");
    again = Console.ReadLine();

    if (again == "n")
    {
        playAgain = false;
    }
    // bulletproof and handle responses other than y/n
    
} while (playAgain = true);


Console.WriteLine("Thank you for playing!");
