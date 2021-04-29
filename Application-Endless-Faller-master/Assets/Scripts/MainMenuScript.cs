using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private Text highscore;
    private float sr;

    void Start()
    {
        highscore = GameObject.Find("Highscore").GetComponent<Text>();
        GameControl.control.Load();
        highscore.text = "Highscore: " + GameControl.control.highscore.ToString();

    }

    public void GetInput(string guess)
    {
        sr = float.Parse(guess);
        if(sr>0 && sr <= 10)
        {
            GameControl.control.spawnRate = float.Parse(guess);
            GameControl.control.Save();
        }
     

    }

}
