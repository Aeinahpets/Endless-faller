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
    public Text highScoreText;
    public Text GameOverScore;
    public Text GameOverHighScore;

    void Start()
    {
        Score = 0;
        GameControl.control.Load();
        highScoreText.text = "Highscore: " + GameControl.control.highscore;

    }

    void Update()
    {
        scoreText.text= "Score: " +Score.ToString();       
        newHighScore();
    }

    public void IncrementScore()
    {
        Score++;
        Debug.Log("score: " + Score);
    }

    public void Reset()
    {
        Score = 0;
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameOverScore.text = "Score: " + Score.ToString();
        GameOverHighScore.text = "Highscore: " + GameControl.control.highscore;
    }

    void newHighScore()
    {
        if (Score > GameControl.control.highscore)
        {
            Debug.Log("New highscore!");
            GameControl.control.highscore = Score;
            GameControl.control.Save();
            highScoreText.color = Color.red;
            highScoreText.text = "Highscore: " + GameControl.control.highscore;
        }

    }
}
