using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumbersWizard : MonoBehaviour
{
    int m_guess;
    [SerializeField] int m_max , m_maxGuessesAllowed , m_min;
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
        m_guess = Random.Range(m_min , m_max + 1);
        m_guessLabel.text = m_guess.ToString();
        m_maxGuessesAllowed--;

        if(m_maxGuessesAllowed < 1)
        {
            SceneManager.LoadScene("Win");
        }
    }

    void StartGame()
    {
        m_guess = Random.Range(m_min , m_max + 1);
        m_guessLabel.text = m_guess.ToString();
        m_max++;
    }
}
