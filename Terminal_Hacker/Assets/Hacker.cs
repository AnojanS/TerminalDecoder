using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game State
    string level; //member variable
    enum Screen { MainMenu, Password, Win}; //screen setting
    Screen currentScreen;
    string password;

    // Start is called before the first frame update
    void Start() {
        ShowMainMenu();
    }

    void ShowMainMenu() {
        currentScreen = Screen.MainMenu;
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
        else if (currentScreen == Screen.MainMenu){
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password) {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1"){
            level = "Easy";
            StartGame();
        }
        else if (input == "2"){
            level = "Hard";
            password = "password";
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

    void CheckPassword(string input) { 

        if (input == password) {
            Terminal.WriteLine("Congratulations, you win!");
        }
        else {
            Terminal.WriteLine("Wrong password. Please try again");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
