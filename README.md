# MonoECS
ECS system designed to be integrated with Monogame
MonoECS is an Entity-Component System written in C#.
It was designed to be integrated with Monogame, but can actually be integrated with anything really.

## Example
```csharp
using MonoECS;
using MonoECS.Core;
using MonoECS.Extensions;
using System;
using System.Threading;

namespace Example
{
    internal class Program
    {
        // Define Position component with X and Y coordinates.
        public class Position : IComponent
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        // Define Renderable component to represent an entity's visual representation.
        public class Renderable : IComponent
        {
            public string Glyph { get; set; }
        }

        // Define LeftMover component to tag entities that move left.
        public class LeftMover : IComponent { }

        // Define Player component to tag player entities.
        public class Player : IComponent { }

        //Systems

        // Implement LeftMoverSystem to move entities with LeftMover and Position components to the left.
        public class LeftMoverSystem : ISystem
        {
            public void Run(World world)
            {
                // Move entities with LeftMover component to the left and wrap around the screen.
                foreach (var (_, pos) in world.Join<LeftMover, Position>())
                {
                    pos.X -= 1;
                    if (pos.X < 0)
                    {
                        pos.X = 79;
                    }
                }
            }
        }

        // GameState manages the game world and the system dispatcher.
        public class GameState
        {
            // Initialize the game world and system dispatcher.
            public World World { get; set; }
            public Dispatcher Dispatcher { get; set; }

            public GameState()
            {
                World = new World();
                Dispatcher = new Dispatcher();
            }

            public void TryMovePlayer(int deltaX, int deltaY)
            {
                foreach (var (_, pos) in World.Join<Player, Position>())
                {
                    pos.X = Math.Max(0, Math.Min(79, pos.X + deltaX));
                    pos.Y = Math.Max(0, Math.Min(29, pos.Y + deltaY));
                }
            }

            public void PlayerInput()
            {
                if (!Console.KeyAvailable) return; // No input, exit early

                var keyInfo = Console.ReadKey(true); // Read the key press without displaying it in the console
                int deltaX = 0, deltaY = 0;

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        deltaX = -1;
                        break;
                    case ConsoleKey.RightArrow:
                        deltaX = 1;
                        break;
                    case ConsoleKey.UpArrow:
                        deltaY = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        deltaY = 1;
                        break;
                }

                TryMovePlayer(deltaX, deltaY);
            }

            // Run game logic: dispatch systems and render entities.
            public void Run()
            {
                // Handle player input for movement
                PlayerInput();

                // Dispatch systems to update entity states.
                Dispatcher.Dispatch(World);

                // Clear the console and render entities with Position and Renderable components.
                Console.Clear();
                foreach (var (pos, render) in World.Join<Position, Renderable>())
                {
                    Console.SetCursorPosition(pos.X, pos.Y);
                    Console.Write(render.Glyph);
                }
            }
        }

        // Entry point: setup and run the game loop.
        static void Main()
        {
            // Hide the console cursor for cleaner rendering.
            Console.CursorVisible = false;
            var gs = new GameState();

            // Add LeftMoverSystem to the dispatcher for processing.
            gs.Dispatcher.AddSystem(new LeftMoverSystem());

            // Create the player entity with Position, Renderable, and Player components.
            gs.World.CreateEntity()
                .With(new Position(40, 5))
                .With(new Renderable() { Glyph = "@" })
                .With(new Player())
                .Build();

            // Create multiple entities with Position, Renderable, and LeftMover components.
            for (int i = 0; i < 10; i++)
            {
                gs.World.CreateEntity()
                .With(new Position(i * 7, 7))
                .With(new Renderable() { Glyph = "@" })
                .With(new LeftMover())
                .Build();
            }

            // Game loop: run game state and sleep for a brief period to control game speed.
            while (true)
            {
                gs.Run();
                Thread.Sleep(100);
            }
        }
    }
}
```

Please look into [the example directory](Example) for more.
