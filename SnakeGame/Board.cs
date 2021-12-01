using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Board
    {
        public readonly int Height;
        public readonly int Width;

        public Board(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public void DrawBoard()
        {
            for (int i = 0; i <= Height; i++)
            {
                Utilities.DrawPosition(Width, i, "#");
                Utilities.DrawPosition(0, i, "#");
            }

            for (int i = 0; i <= Width; i++)
            {
                Utilities.DrawPosition(i, 0, "#");
                Utilities.DrawPosition(i, Height, "#");
            }
        }
    }
}
