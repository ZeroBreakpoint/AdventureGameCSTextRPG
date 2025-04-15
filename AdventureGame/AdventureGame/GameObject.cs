using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    // Abstract base class for all entities that can be placed in a Room
    // Includes Player, Enemy, PowerUp – any object drawn on the map
    abstract class GameObject
    {
        // Protected constructor to allow subclassing only
        protected GameObject() { }

        // Abstract method ensures every subclass defines how it appears on the map
        public abstract void Draw();
    }
}
