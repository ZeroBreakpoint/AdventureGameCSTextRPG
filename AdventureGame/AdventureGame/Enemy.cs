using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    // Enemy class represents AI/static enemies on the map
    class Enemy(int hp, int attack, int defense) : Character(hp, attack, defense)
    {
        // Draw logic changes based on current HP
        // More than 10 HP = 'O'; otherwise = 'o'
        public override void Draw()
        {
            Console.Write(hp > 10 ? 'O' : 'o');
        }
    }
}
