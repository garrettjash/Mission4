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

*/

