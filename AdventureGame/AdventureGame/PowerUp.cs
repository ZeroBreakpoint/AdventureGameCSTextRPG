using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    // PowerUp is a passive collectible item in the game
    class PowerUp : GameObject
    {
        // Draws '?' on the map to indicate a powerup location
        public override void Draw()
        {
            Console.Write('?');
        }
    }
}
