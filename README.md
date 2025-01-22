# C# Arena Battle Game

Welcome to the **C# Arena Battle Game!** ⚔️🔥

This project is an interactive console-based game where four unique heroes battle against each other in an arena. Each hero has their own special abilities that influence the outcome of the battle.

## 📝 Project Overview

The game consists of four heroes:
- **Harbour** – A resilient character with defensive capabilities.
- **Heatblast** – A fiery hero with offensive powers.
- **Knight** – A noble warrior with balanced attack and defense.
- **Rogue** – A stealthy fighter with agility and critical strikes.

The battle takes place in an **Arena**, where the heroes fight until only one remains victorious. The game utilizes core object-oriented programming principles such as inheritance and polymorphism to model the heroes and their interactions.

## 🛠️ Project Structure

The project contains the following main components:

### 1️⃣ Classes
- **Hero.cs** – Base class that defines shared properties and methods for all heroes.
- **Knight.cs, Rogue.cs, Heatblast.cs, Harbour.cs** – Specialized hero classes with unique abilities.
- **Arena.cs** – Handles the battle logic between heroes.
- **GameEventListener.cs** – Provides a mechanism to track events during the battle.

### 2️⃣ Program Execution
- **Program.cs** – Entry point of the application where the game is initialized and the battle begins.

## ⚙️ How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/ArenaBattleGame.git
   ```
2. Navigate to the project directory:
   ```bash
   cd ArenaBattleGame
   ```
3. Build the project:
   ```bash
   dotnet build
   ```
4. Run the game:
   ```bash
   dotnet run
   ```

## 🎮 Gameplay

- The game starts with four heroes entering the arena.
- Each round, two heroes are randomly selected to fight.
- The attacker deals damage to the defender based on their abilities.
- Special interactions, such as Heatblast dealing no damage to Harbour, are implemented.
- The game continues until only one hero remains.

## 🚀 Features

- Engaging console-based gameplay.
- Randomized battle sequences.
- Hero-specific abilities and interactions.
- Event-based logging of the battle process.

## 📚 Technologies Used

- C#
- .NET Core
- Object-Oriented Programming (OOP)

## 🤝 Contributing

Feel free to contribute by submitting pull requests or reporting issues.

## 🏆 Acknowledgments

A big thanks to the C# community for inspiration and support!

---

Enjoy battling and may the strongest hero win! 🏆

