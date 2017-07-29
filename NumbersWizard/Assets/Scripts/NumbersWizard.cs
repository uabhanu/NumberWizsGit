using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersWizard : MonoBehaviour
{
    int m_guess , m_max , m_min;

	void Start()
    {
        StartGame();
	}

    void Update()
    {
        if(Time.timeScale == 0) //Useful for checking if game is paused or not
        {
            return;
        }

        UserInput();
    }

    void NextGuess()
    {
        m_guess = (m_max + m_min) / 2;
        print("Higher or Lower than : " + m_guess);
        print("Up = Higher , Down = Lower & Return = Equal");
    }

    void StartGame()
    {
        m_guess = 500;
        m_max = 1000;
        m_min = 1;

        //print("Select a range if numbers between which you want to choose");
        //print("Please enter maximum number");
        //m_max should take the user entered number and so on. NumbersWizard Course complete, up to you to finish the rest

        print("Pick a number in your head but don't tell me");

        print("The highest number you can pick is " + m_max);
        print("The lowest number you can pick is " + m_min);

        print("Is the number higher or lower than : " + m_guess);
        print("Up = Higher , Down = Lower & Return = Equal");

        m_max++;
    }

    void UserInput()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_max = m_guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_min = m_guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
            print("I Won");
            StartGame();
        }
    }
}
