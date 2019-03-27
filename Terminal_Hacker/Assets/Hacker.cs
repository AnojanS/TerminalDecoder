using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game State
    string level; //member variable
    enum Screen { MainMenu, Password, Win}; //screen setting
    Screen currentScreen = Screen.MainMenu;

    // Start is called before the first frame update
    void Start() {
        ShowMainMenu();
    }

    void ShowMainMenu() {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello! Choose your difficulty");
        Terminal.WriteLine("Press 1 for Easy");
        Terminal.WriteLine("Press 2 for Hard");
        Terminal.WriteLine("Enter your choice: ");
    }

    void OnUserInput(string input) {
        if(input == "menu") {
            ShowMainMenu();
        }
        else if (input == "1") {
            level = "Easy";
            StartGame();
        }
        else if (input == "2") {
            level = "Hard";
            StartGame();
        }
        else {
            Terminal.WriteLine("Please enter a valid input");
        }
    }

    void StartGame() {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen " + level + " mode");
        Terminal.WriteLine("Please enter your password: ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
