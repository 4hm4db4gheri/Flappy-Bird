using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.TextCore.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private TextMeshProUGUI _gameCurrentScore;
    [SerializeField] private TextMeshProUGUI _gameHighestScore;
    private int _currentScore = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Time.timeScale = 1f;
    }

    private void Start()
    {
        _gameHighestScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void gameOver()
    {
        _gameOverScreen.SetActive(true);
        if (_currentScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore",_currentScore);
            _gameHighestScore.text = _currentScore.ToString();
        }
        Time.timeScale = 0f;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        _gameHighestScore.text = _currentScore.ToString();
    }

    public void gotScore()
    {
        _currentScore++;
        _gameCurrentScore.text = _currentScore.ToString();
    }
}
