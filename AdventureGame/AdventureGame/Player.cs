using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    // Player class inherits from Character and represents the controllable character
    class Player : Character
    {
        // Initialize Player with example stats (can be expanded later)
        public Player() : base(100, 10, 5) { }

        // Draw 'X' to represent player position on the map
        public override void Draw()
        {
            Console.Write('X');
        }
    }
}
