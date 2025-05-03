# Vials-Game

This project is a simple Windows Forms game called "Potion Master". The goal of this game is to rearrange the liquid in the Vials so that all non-empty Vials are filled with one-colored liquid segments. You can only pour liquid from one Vial to another when both of them have the same-colored segment on top. There is no lost state defined - when you are out of moves, you have to start a new game. Your score is constantly being tracked, and best one saved throughout User Settings (binded to your local account on your computer).

The primary components of the project include:

- A form-based UI consisting of Vials, Next Game/Undo Buttons, Score/Best Score counter, Menu Strip and Text Box for feedback on current game state.
- Custom VialControl derived from UserControl that gives an independant interface for a Vial mechanic
- Custom Settings Dialog that allows user to change game settings
- Custom event handler for signaling drag-drop events on vials
- Error checking and data validation for each input form

## Features

- **Controlling game settings** (Difficulty, Vials Count, Segment Count, Color Theme) that are **saved** between app instances.
- **Undo** mechanics (limited number of undos for different Diffuculties).
- **Score** counting mechanics **dependant** on Difficulty, Segment Count and Vials Count.
- **Color Themes** (Light/Dark) that change the appearance of different game components.
- **Best score** tracking throughout app instances.
  
## Technologies

- **C#** and **.NET Framework**: The application is built using C# in a Windows Forms environment.
- **Singleton** for managing Undo mechanics.
- **Abstract factory** for creating different Color-Theme presets

## Usage

### Setting Up

1. Clone this repository to your local machine:
    ```bash
    git clone https://github.com/xxxDKGxxx/Vials-Game.git
    ```

2. Open the project in Visual Studio or your preferred C# IDE.

3. Build the project and run the application.

### Running the Application
