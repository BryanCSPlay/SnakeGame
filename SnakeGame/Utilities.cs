using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public static class Utilities
    {
        public static void DrawPosition(int x, int y, string caracter)
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine(caracter);
        }
    }
}
