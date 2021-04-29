using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class GameControl : MonoBehaviour
{
    public static GameControl control;

    public int highscore;
    public float spawnRate;

    private void Awake()
    {
        if (control == null)
        {
            control = this;
        }else if(control != this)
        {
            Destroy(gameObject);
        }
    }


    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.highscore = highscore;
        data.spawnRate = spawnRate;

        bf.Serialize(file,data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            highscore = data.highscore;
            spawnRate = data.spawnRate;
        }



    }

}
[Serializable]
class PlayerData
{
    public int highscore;
    public float spawnRate;
}