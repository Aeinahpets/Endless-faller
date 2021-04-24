using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> Manages the state of the level </summary>
public class LevelManager : MonoBehaviour
{
    public int Score;
    

    void Start()
    {
        Score = 0;
    }

    void Update()
    {
        
    }

    public void IncrementScore()
    {
        Score++;
    }

    public void Reset()
    {
        Score = 0;
        // reset logic
    }
}
