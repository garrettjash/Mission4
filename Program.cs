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
char turn = 'X';
bool winner = false;
int position = 0;


Console.WriteLine("Welcome to TicTacToe!");
// Add code to show the user the board layout 

char[] gameBoard = [];

do
{
    // Clear game board
    gameBoard = [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '];

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
        //printBoard(gameBoard);

    }


    
} while (playAgain = true);


Console.WriteLine("Thank you for playing!");
