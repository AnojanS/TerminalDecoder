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
        Terminal.WriteLine("Hello! Choose your hacking difficulty");
        Terminal.WriteLine("Press 1 for Easy");
        Terminal.WriteLine("Press 2 for Hard");
        Terminal.WriteLine("Enter your choice: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") // we can always go direct to main menu
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1"){
            level = 1;
            StartGame();
        }
        else if (input == "2"){
            level = 2;
            StartGame();
        }
        else if (input == "007"){
            Terminal.WriteLine("Please select a level Mr Bond!");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
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
