using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    int level; // game state
    Screen currentScreen = Screen.MainMenu;
    enum Screen {
        MainMenu,
        Password,
        Win
    };
    // Use this for initialization
    void Start() {
        CookCurry("lamb");
    }

    void ShowMainMenu() {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter your selection");
    }

    void CookCurry(string meatToUse) {
        // common cooking steps go here
        print("I am adding the " + meatToUse);
    }

    void OnUserInput(string input) { // this should only decide who to handle input, not actually do it.
        if (input == "menu") { // From every input, we can always go direct to main menu.
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu) {
            RunMainMenu(input);
        }
    }

    private void RunMainMenu(string input) {
        if (input == "1") {
            level = 1;
            StartGame();
        }
        else if (input == "2") {
            level = 2;
            StartGame();
        }
        else if (input == "007") {
            Terminal.WriteLine("Please select a level, Mr. Bond");
        }
        else {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame() {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }
}