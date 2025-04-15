using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    // Abstract class for characters that have stats like HP, Attack, and Defense
    // Shared by Player and Enemy
    abstract class Character(int hp, int attack, int defense) : GameObject
    {
        // Protected stat fields for subclass access
        protected int hp = hp;
        protected int attack = attack;
        protected int defense = defense;
    }
}
