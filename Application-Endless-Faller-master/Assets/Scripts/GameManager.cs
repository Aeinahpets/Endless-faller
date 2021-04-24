﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

/// <summary> Manages the state of the whole application </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField] private string gameScene;

    public void Play()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER");
    }
}