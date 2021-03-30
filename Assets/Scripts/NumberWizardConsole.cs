using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardConsole : MonoBehaviour
{
    int maximum;
    int minimum;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("\n____________________________________________________________________________________________");

        maximum = 1000;
        minimum = 1;
        guess = 500;

        Debug.Log("\nNamaste, Welcome to Number Wizard");
        Debug.Log("\nPick a Number for me to guess...");
        Debug.Log("\nThe Highest Number you can pick is: " + maximum);
        Debug.Log("\nThe Lowest Number you can pick is: " + minimum);
        Debug.Log("\n1. Press Up Arrow Key for if I should guess Higher");
        Debug.Log("\n2. Press Down Arrow Key for if I should guess Lower");
        Debug.Log("\n3. Press Enter Key if I have guessed your Number correctly");
        Debug.Log("\nShould I guess Higher or Lower than: " + guess);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (guess == 1000)
            {
                Debug.Log("\nEither your guess is 1000 or you have picked a number greater than 1000");
                StartGame();
            }
            else
            {
                minimum = guess + 1;
                NextGuess();
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (guess == 1)
            {
                Debug.Log("\nEither your guess is 1 or you have picked a number lower than 1");
                StartGame();
            }
            else
            {
                maximum = guess;
                NextGuess();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("\nYay my guess " + guess + " is correct");
            Debug.Log("\nI told you I am a Wizard");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (maximum + minimum) / 2;
        Debug.Log("\nShould I guess Higher or Lower than my current guess " + guess + "?");
    }
}
