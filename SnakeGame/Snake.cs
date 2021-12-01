using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake
    {
        List<Position> Queue { get; set; }
        Direction Direction { get; set; }
        public int Points { get; set; }

        public Snake(int x, int y)
        {
            Position initialPosition = new Position(x,y);
            Queue = new List<Position>();
            Direction = Direction.Down;
        }

        public void Death()
        {

            throw new NotImplementedException();
        }

        public void Move()
        {

            throw new NotImplementedException();
        }

        public void EatCandy()
        {

            throw new NotImplementedException();
        }
    }
}
