using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    int level; // game state
    string[] level1Passwords = { "books", "aisle", "self", "password", "font", "borrow" };
    string[] level2Passwords = { "january", "suborbital", "denomination", "jackdaw", "random", "notpassword" };
    Screen currentScreen = Screen.MainMenu;
    string password;

    enum Screen {
        MainMenu,
        Password,
        Win
    };

    void ShowLevelReward() {
        switch (level) {
            case 1:
                Terminal.WriteLine("Have a book...");
                Terminal.WriteLine(@"
(•_•)

( •_•)>⌐■-■

(⌐■_■)

");
                break;
            case 2:
                Terminal.WriteLine("You got a prison key!");
                Terminal.WriteLine(@"Here's your key you filthy animal");
                break;
            default:
                Debug.LogError("Invalid Level reached.");
                break;
        }
    }

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
        else if (currentScreen == Screen.Password) {
            CheckPassword(input);
        }
    }

    private void RunMainMenu(string input) {
        bool isValidLevelNumber = (input == "1" || input == "2");
        if (isValidLevelNumber) {
            level = int.Parse(input);
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
        Terminal.ClearScreen();
        Terminal.WriteLine("Please enter your password: ");
        switch (level) {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length - 1)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length - 2)];
                break;
            default:
                break;
        }
    }

    void CheckPassword(string input) {
        if (input == password) {
            Terminal.WriteLine("Well done.");
        }
        else {
            Terminal.WriteLine("Wrong password");
        }
    }

    void DisplayWinScreen() {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }
}