using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumbersWizard : MonoBehaviour
{
    int m_guess , m_max , m_min;
    [SerializeField] int m_maxGuessesAllowed;
    [SerializeField] Text m_guessLabel;

	void Start()
    {
        StartGame();
	}

    public void GuessLow()
    {
        m_max = m_guess;
        NextGuess();
    }

    public void GuessHigh()
    {
        m_min = m_guess;
        NextGuess();
    }

    void NextGuess()
    {
        m_guess = (m_max + m_min) / 2;
        m_guessLabel.text = m_guess.ToString();
        m_maxGuessesAllowed--;

        if(m_maxGuessesAllowed < 1)
        {
            SceneManager.LoadScene("Win");
        }
    }

    void StartGame()
    {
        m_guess = 500;
        m_max = 1000;
        m_min = 1;
        m_max++;
    }
}
