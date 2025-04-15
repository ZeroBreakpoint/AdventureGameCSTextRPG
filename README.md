# AdventureGameCSTextRPG

A compact, object-oriented text-based RPG implemented in C#.  Built in the early stages of me learning C# follow a specified UML diagram, this project demonstrates solid understanding of inheritance, abstract classes, encapsulation and game state rendering through console output.

## Summary

This 3x3 grid-based adventure game features:
- A `Room` system that can hold up to 3 entities at once.
- Abstract base classes (`GameObject`, `Character`) enforcing polymorphic behavior.
- Three interactive object types: `Player`, `Enemy`, and `PowerUp`, each with custom rendering logic.
- A basic game loop with player-controlled movement (`W`, `A`, `S`, `D`) and live map rendering.
- Encapsulation of game state management using the `GameManager` class.

## Controls

- **W / A / S / D** — Move the player around the grid
- **Q** — Quit the game

## Objects & Rendering Rules

- `Player` — Draws `'X'`
- `Enemy` — Draws `'O'` if HP > 10, otherwise `'o'`
- `PowerUp` — Draws `'?'`
- `Room` — Draws `'_'` when empty; prioritizes rendering Player > Enemy > PowerUp

## Object-Oriented Design

- Fully adheres to the class structure specified in the UML diagram provided.
- Includes custom logic for object storage and removal, ensuring null gaps are re-ordered properly in each room.

## Technologies

- Language: C#
- Runtime: .NET Core
- Console-based application

This project highlights my ability to apply core object-oriented programming principles to a gameplay scenario.
