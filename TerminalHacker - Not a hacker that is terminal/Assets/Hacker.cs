﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    // Use this for initialization
    void Start() {
        ShowMainMenu("Hello Ben");
        CookCurry("lamb");
    }

    void ShowMainMenu(string greeting) {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter your selection");
    }

    void CookCurry(string meatToUse) {
        // common cooking steps go here
        print("I am adding the " + meatToUse);
    }

    // Update is called once per frame
    void Update() {
    }
}