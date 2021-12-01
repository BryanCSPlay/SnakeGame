using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(20, 20);
            board.DrawBoard();

            Console.ReadKey();
        }
    }
}
