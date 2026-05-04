<div id="top">

<div align="center">

# 🪄 VR Voice Command Spell Casting Demo

<em>Unleash Magic Through Voice in Virtual Reality</em>

<!-- BADGES -->
<img src="https://img.shields.io/github/last-commit/7450N/VR-Voice-Command-Spell-Casting-Demo?style=flat&logo=git&logoColor=white&color=0080ff" alt="last-commit">
<img src="https://img.shields.io/badge/Language-C%23-0080ff?style=flat&logo=csharp&logoColor=white" alt="repo-2nd-language">
<img src="https://img.shields.io/badge/Unity-FFFFFF.svg?style=flat&logo=Unity&logoColor=black" alt="Unity">
<img src="https://img.shields.io/badge/Hardware-Meta_Quest-045981?style=flat&logo=meta&logoColor=white" alt="Meta">

</div>
<br>

---

## ✨ Overview

**VR-Voice-Command-Spell-Casting-Demo** is an innovative Unity project demonstrating how voice recognition can transform immersive VR experiences. By seamlessly combining Meta's XR Interaction Toolkit with Wit.ai voice recognition, this project enables hands-free, natural spell casting within a virtual environment. 

All spells are inspired by the Harry Potter universe, allowing users to interact with physics-based objects using voice commands and wand gestures.

### 🎯 Key Features
- **Voice-Driven Spell Casting:** Implements natural language processing (Wit.ai) to trigger spell-casting actions hands-free.
- **Physics-Based Magic Mechanics:** Features modular spell scripts (e.g., *Accio*, *Depulso*) that interact dynamically with Rigidbodies.
- **Optimized XR Environment:** Utilizes occlusion culling, baked lighting, and modular asset architecture to maintain high-fidelity performance on standalone VR headsets.
- **Immersive Feedback:** Enhances interactions with dynamic visual particle effects, animations, and controller haptics.

---

## 🎥 Demo

Watch the voice-activated spell casting in action:

[![YouTube Video](https://img.youtube.com/vi/Mm-soWWjgCQ/maxresdefault.jpg)](https://youtu.be/Mm-soWWjgCQ)

---

## 🛠️ Core Technologies

| Category | Technology |
|---|---|
| **Game Engine** | Unity 3D (C#) |
| **VR Hardware** | Meta Quest (OpenXR) |
| **Interaction System**| XR Interaction Toolkit (XRI) |
| **Voice Recognition** | Wit.ai Integration |
| **Animation** | DOTween, Unity Animator |

---

## 🧠 System Architecture & Key Scripts

Rather than listing standard Unity assets, below is an overview of the custom logic and architecture developed for this project. All core gameplay scripts can be found in `Assets/Resources/Scripts/`.

*   `ActivateVoice.cs`  
    **The Voice Controller:** Bridges the user's XR input with the Wit.ai speech recognition service. It listens for specific keyword intents and routes them to the wand controller.
*   `Wand.cs`  
    **The Casting Hub:** Acts as the central orchestrator for the player's wand. It receives validated voice intents, manages raycasting for spell targeting, and triggers the appropriate spell effects (visuals, sounds, and physics).
*   `Accio.cs` & `DepulsoTarget.cs`  
    **Physics Manipulation:** Custom scripts attached to interactable objects. They calculate directional vectors and apply Rigidbody forces (pulling or pushing) based on the spell cast by the player.
*   `Shield.cs`  
    **Defensive Mechanics:** Instantiates a temporary protective barrier, managing its own lifecycle, particle emissions, and collision detection before automatically despawning.
*   `MeshExploder.cs` *(SmallBigSquare Integration)*  
    **Destruction Logic:** Handles the dynamic subdivision and retopology of meshes when targeted by destructive spells, turning static objects into physics-enabled fragments.

---

## 🚀 Getting Started

*(Add brief instructions here on how someone can clone your repo, add their own Wit.ai API key if necessary, and build it to their Quest headset).*

</div>
