using System;

namespace AdventureGame
{
    class Program
    {
        // Entry point: launches GameManager loop
        static void Main()
        {
            GameManager game = new();
            game.Run();
        }
    }
}