# 🎮 DoomJump - 2D Platformer Game

<p align="center">
  <img src="https://img.shields.io/badge/Made%20With-Unity-black?style=for-the-badge&logo=unity&logoColor=white" alt="Unity Badge" />
</p>

Welcome to **DoomJump**, a high-octane 2D platformer game heavily inspired by the mechanics of classic retro side-scrollers like *Super Mario*! Built completely with **Unity**, this project showcases customized double-jump mechanics, smooth movement physics, pathfinding enemy AI, synchronized moving platforms, and a dynamic graphical health UI.

---

## 🌟 Game Overview & Key Features

DoomJump brings back the nostalgia of vintage 8-bit platformers combined with responsive, tight controls and multi-layered stage layouts.

* **🏃 Advanced Physics Movement:** Fluid acceleration mechanics featuring a fully coded **Double Jump** framework to navigate wide pits and multi-level platforms.
* **⚙️ Sticking Moving Platforms:** Intelligently pathed 2D platforms that automatically anchor the player as a child transform when landed upon, eliminating slips or jitter.
* **👾 Smart Patrol AI:** Advanced enemy state tracking that monitors directional vectors to flip enemy sprites dynamically based on movement.
* **❤️ Filled Health Bar System:** A structured graphical interface tracking the player's life index using fill fractions, complete with automated red flash screen animations on collision damage.
* **📐 Immersive Level Design:** A sweeping single-stage landscape packed with deadly spikes, calculated jumps, and rhythmic patrol lines leading to the end flag.

---

## 📸 Game Screenshots

### 🗺️ Full Level Map Layout
<p align="center">
  <img src="Game Images/FullMap.png" width="100%" alt="Full Level Design Map View" />
</p>

### 🕹️ Gameplay Action
<p align="center">
  <img src="Game Images/GamePlay1.png" width="48%" alt="Gameplay Action View 1" />
  <img src="Game Images/GamePlay2.png" width="48%" alt="Gameplay Action View 2" />
</p>

---

## 🎮 Game Controls

| Action | Control Key |
| :--- | :--- |
| **Walk Right** | ➡️ Arrow Right / **D** |
| **Walk Left** | ⬅️ Arrow Left / **A** |
| **Jump** | **Spacebar** |
| **Double Jump** | **Spacebar (Double Tap)** *[Jump again while mid-air!]* |

---

## ⚙️ Project Setup Guide

DoomJump is built as a native **Unity Hub** project architecture, making local installation effortless:

### Prerequisites
* **Unity Hub** (Latest Version)
* **Unity Editor (2022.3 LTS or newer)** recommended with the *2D Development toolset* configured.

### Quick Installation

1. **Clone the Project:** Open your local terminal/Git Bash window and drop this command:
   ```bash
   git clone git@github.com:Jeyasuriya-pillai/DoomJump-2DGame.git
