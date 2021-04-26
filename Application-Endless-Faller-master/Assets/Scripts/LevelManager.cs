using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary> Manages the state of the level </summary>
public class LevelManager : MonoBehaviour
{
    public int Score;
    public GameObject GameOverUI;
    public Text scoreText;
    public Text GameOverScore;

    void Start()
    {
        Score = 0;
    }

    void Update()
    {
        scoreText.text= "Score: " +Score.ToString();
    }

    public void IncrementScore()
    {
        Score++;
        Debug.Log("score: " + Score);
    }

    public void Reset()
    {
        Score = 0;
        // reset logic
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameOverScore.text = "Score: " + Score.ToString();
    }


}
