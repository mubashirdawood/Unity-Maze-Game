# 🌿 Unity Maze Game

<p align="center">
  <img src="https://img.shields.io/badge/Unity-6000.6.1f1-black?logo=unity&logoColor=white" />
  <img src="https://img.shields.io/badge/Render%20Pipeline-URP-blue?logo=unity" />
  <img src="https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white" />
  <img src="https://img.shields.io/badge/Platform-Windows%20%7C%20Mac%20%7C%20Android-informational" />
  <img src="https://img.shields.io/badge/Version-0.1.0-orange" />
  <img src="https://img.shields.io/github/license/mubashirdawood/Unity-Maze-Game" />
</p>

<p align="center">
  A 3D top-down maze navigation game built with <strong>Unity 6</strong> and the <strong>Universal Render Pipeline (URP)</strong>. Navigate through a terrain-based maze, dodge obstacles, and reach the goal to win!
</p>

---

## 📋 Table of Contents

- [About the Game](#-about-the-game)
- [Features](#-features)
- [Gameplay](#-gameplay)
- [Controls](#-controls)
- [Getting Started](#-getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Opening the Project](#opening-the-project)
- [Project Structure](#-project-structure)
- [Scripts Overview](#-scripts-overview)
- [Built With](#-built-with)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎮 About the Game

**Unity Maze Game** is a 3D maze exploration game where the player navigates through a terrain-sculpted environment to find and reach the goal. The game uses Unity's physics engine for smooth, realistic movement and features a beautiful outdoor environment with custom terrain layers and tree foliage.

The project was built as a learning exercise to explore:
- Unity's **URP (Universal Render Pipeline)**
- **Terrain tools** and landscape design
- **Rigidbody-based** player movement
- **Trigger-based** goal detection

---

## ✨ Features

| Feature | Description |
|---------|-------------|
| 🏃 Smooth Player Movement | Physics-based Rigidbody movement with no gravity drift |
| 🗺️ Terrain Maze | Multi-layer terrain with custom materials and tree foliage |
| 🎯 Goal System | Trigger-based goal detection — reach the goal to win |
| 🌿 Environment | Richly decorated scenes with terrain layers and trees |
| 🎨 URP Rendering | Modern visuals powered by Universal Render Pipeline |
| 📐 Constraint Physics | Player locked to Y-axis to prevent unwanted tilting |

---

## 🕹️ Gameplay

1. The player spawns at the **start of the maze**
2. Use keyboard controls to **navigate through the maze corridors**
3. The maze is built using **sculpted terrain** with physical boundaries
4. **Find and reach the goal object** to complete the level
5. The goal disappears upon contact — confirming your victory!

---

## ⌨️ Controls

| Key | Action |
|-----|--------|
| `W` / `↑` | Move Forward |
| `S` / `↓` | Move Backward |
| `A` / `←` | Move Left |
| `D` / `→` | Move Right |

> Movement is **normalized** — diagonal movement won't be faster than straight movement.

---

## 🚀 Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- **Unity Hub** — [Download here](https://unity.com/download)
- **Unity Editor 6000.6.1f1** (or compatible version) with the following modules:
  - Windows Build Support (or your target platform)
  - Universal Windows Platform Build Support *(optional)*

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/mubashirdawood/Unity-Maze-Game.git
   ```

2. **Navigate into the project folder:**

   ```bash
   cd Unity-Maze-Game
   ```

### Opening the Project

1. Open **Unity Hub**
2. Click **"Open"** → **"Add project from disk"**
3. Select the cloned `Unity-Maze-Game` folder
4. Unity will automatically install the correct editor version if prompted
5. Once open, navigate to `Assets/Scenes/SampleScene.unity` and double-click to load it
6. Press the **▶ Play** button to start the game!

> ⚠️ **Note:** The `Library/` folder is not included in the repository. Unity will **automatically regenerate it** the first time you open the project. This may take a few minutes.

---

## 📁 Project Structure

```
Unity-Maze-Game/
│
├── Assets/                         # All game assets
│   ├── Scenes/
│   │   └── SampleScene.unity       # Main game scene
│   ├── Settings/                   # URP renderer & pipeline settings
│   ├── Tree_Textures/              # Tree texture assets
│   ├── Tree 1_Textures/            # Additional tree texture set
│   ├── TutorialInfo/               # Unity template tutorial assets
│   ├── GoalScript.cs               # Goal detection logic
│   ├── PlayerMovement.cs           # Player movement controller
│   ├── InputSystem_Actions.inputactions  # Input system config
│   ├── New Material.mat            # Terrain/object materials
│   ├── New Terrain.asset           # Main terrain data
│   ├── New Terrain 1.asset         # Secondary terrain data
│   ├── New Terrain 2.asset         # Tertiary terrain data
│   └── NewLayer.terrainlayer       # Terrain painting layers
│
├── Packages/
│   ├── manifest.json               # Unity package dependencies
│   └── packages-lock.json          # Locked package versions
│
├── ProjectSettings/                # Unity project configuration
│   ├── ProjectSettings.asset       # Core settings (app name, version, etc.)
│   ├── ProjectVersion.txt          # Unity editor version
│   └── ...                         # Other setting assets
│
├── .gitignore                      # Git ignore rules for Unity
└── README.md                       # This file
```

---

## 📜 Scripts Overview

### `PlayerMovement.cs`

Handles all player movement using Unity's **Rigidbody** physics system.

```csharp
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
```

**Key behaviors:**
- Uses `Input.GetAxisRaw()` for responsive, snappy controls
- Movement is **normalized** to prevent faster diagonal movement
- **Y position is frozen** — player stays flat on the terrain
- **Rotation is frozen** — prevents physics-based spinning
- Gravity disabled — uses a flat, top-down movement style
- Movement applied via `rb.MovePosition()` in `FixedUpdate` for smooth physics

**Configurable properties:**

| Property | Default | Description |
|----------|---------|-------------|
| `speed` | `5f` | Player movement speed (units/second) |

---

### `GoalScript.cs`

Handles the win condition using Unity's **trigger collider** system.

```csharp
public class GoalScript : MonoBehaviour
```

**Key behaviors:**
- Listens for `OnTriggerEnter` collision events
- Checks if the colliding object has the **"Player"** tag
- On success: logs a congratulations message and **deactivates the goal object**

> 💡 To extend this: you can add scene transitions, UI popups, or score tracking inside `GoalScript.cs`.

---

## 🛠️ Built With

| Tool | Version | Purpose |
|------|---------|---------|
| [Unity](https://unity.com/) | 6000.6.1f1 | Game engine |
| [Universal Render Pipeline](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest) | 17.x | Modern rendering |
| [Unity Input System](https://docs.unity3d.com/Packages/com.unity.inputsystem@latest) | Latest | Input handling |
| C# | .NET Standard 2.1 | Scripting language |
| Unity Terrain Tools | Built-in | Level/map design |

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

1. Fork the project
2. Create your feature branch: `git checkout -b feature/AmazingFeature`
3. Commit your changes: `git commit -m 'Add some AmazingFeature'`
4. Push to the branch: `git push origin feature/AmazingFeature`
5. Open a **Pull Request**

---

## 💡 Future Improvements

- [ ] Add a timer system for speed runs
- [ ] Add multiple levels / maze layouts
- [ ] Implement a minimap
- [ ] Add sound effects and background music
- [ ] Add a main menu and pause screen
- [ ] Add enemy/obstacle AI

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

<p align="center">
  Made with ❤️ using Unity 6 &nbsp;|&nbsp; 
  <a href="https://github.com/mubashirdawood/Unity-Maze-Game">GitHub Repository</a>
</p>
