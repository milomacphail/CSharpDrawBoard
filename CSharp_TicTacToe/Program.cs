using System;

namespace CSharp_TicTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            char[,] board = new char[3, 3];
            board[0, 0] = 'X';
            board[2, 2] = 'O';

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(board[0,0]+ "| |O");
            Console.WriteLine("X|X|O");
            Console.WriteLine(" |" + board[2,2] + "|O");
        }
    }
}
