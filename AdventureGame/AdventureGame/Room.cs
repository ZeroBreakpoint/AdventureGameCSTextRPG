using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    // Room represents a single space on the 3x3 grid
    // Can contain up to 3 GameObjects
    class Room
    {
        // Holds the objects in the room; GameObject? allows nulls
        protected GameObject?[] objects;

        public Room()
        {
            objects = new GameObject?[3]; // Always 3 slots available
        }

        // Add a GameObject into the first available (null) slot
        public void AddGameObject(GameObject obj)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == null)
                {
                    objects[i] = obj;
                    break;
                }
            }
        }

        // Remove a GameObject, then shift remaining objects left to avoid gaps
        public void RemoveGameObject(GameObject obj)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == obj)
                {
                    objects[i] = null;
                    break;
                }
            }

            // Shift non-null objects forward
            GameObject?[] newObjects = new GameObject?[3];
            int index = 0;

            foreach (var item in objects)
            {
                if (item != null)
                {
                    newObjects[index++] = item;
                }
            }

            objects = newObjects;
        }

        // Draw the most relevant object in the room
        // Prioritize Player > others > empty
        public void Draw()
        {
            // If Player is in the room, draw them first
            foreach (var obj in objects)
            {
                if (obj is Player)
                {
                    obj.Draw();
                    return;
                }
            }

            // Otherwise, draw the first non-null object (Enemy or PowerUp)
            foreach (var obj in objects)
            {
                if (obj != null)
                {
                    obj.Draw();
                    return;
                }
            }

            // Empty room
            Console.Write('_');
        }
    }
}
