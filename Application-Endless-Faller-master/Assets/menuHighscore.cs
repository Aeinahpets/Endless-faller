using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuHighscore : MonoBehaviour
{

    public Text highscore;

    void Start()
    {
        GameControl.control.Load();
        highscore.text = "Highscore: " + GameControl.control.highscore.ToString();

    }

}
