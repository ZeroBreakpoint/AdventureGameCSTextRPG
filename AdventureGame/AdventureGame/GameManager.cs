using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    // GameManager handles the main loop, movement logic, and rendering
    class GameManager
    {
        private readonly Room[,] map; // 3x3 grid of rooms
        private int playerRow = 1; // Player starting row
        private int playerCol = 1; // Player starting column
        private readonly Player player;

        public GameManager()
        {
            map = new Room[3, 3];

            // Initialize each room
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    map[row, col] = new Room();
                }
            }

            // Add initial game objects to the map
            player = new Player();
            map[playerRow, playerCol].AddGameObject(player); // Player in center
            map[2, 0].AddGameObject(new Enemy(10, 27, 6)); // Enemy in bottom-left
            map[0, 1].AddGameObject(new PowerUp());               // PowerUp in top-center
        }

        // Game loop
        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                DrawMap(); // Re-render map after each action

                Console.WriteLine("\nMove with W A S D. Press Q to quit.");

                var key = Console.ReadKey(true).Key;

                // Handle input for movement or exit
                switch (key)
                {
                    case ConsoleKey.W: MovePlayer(-1, 0); break;
                    case ConsoleKey.S: MovePlayer(1, 0); break;
                    case ConsoleKey.A: MovePlayer(0, -1); break;
                    case ConsoleKey.D: MovePlayer(0, 1); break;
                    case ConsoleKey.Q: running = false; break;
                }
            }
        }

        // Handle movement and keep player within bounds
        private void MovePlayer(int dRow, int dCol)
        {
            int newRow = playerRow + dRow;
            int newCol = playerCol + dCol;

            // Prevent moving outside the 3x3 grid
            if (newRow < 0 || newRow >= map.GetLength(0) || newCol < 0 || newCol >= map.GetLength(1))
                return;

            map[playerRow, playerCol].RemoveGameObject(player);   // Remove from old room
            playerRow = newRow;
            playerCol = newCol;
            map[playerRow, playerCol].AddGameObject(player);      // Add to new room
        }

        // Output current map state to the console
        private void DrawMap()
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    map[row, col].Draw();
                }
                Console.WriteLine();
            }
        }
    }
}