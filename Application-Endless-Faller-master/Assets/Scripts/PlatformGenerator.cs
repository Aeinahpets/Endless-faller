using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public Transform FirstPlatform;
    public List<GameObject> NextPlatformList;
    private float distaceBetween;
    public Transform SpawnNext;

    void Update()
    {
        if(FirstPlatform.position.y > -1)
        {
            spawn();
        }

    }


    private void spawn()
    {
        GameObject NextPlatform = NextPlatformList[Random.Range(0,NextPlatformList.Count)];
      Transform nextPlatformPos= Instantiate(NextPlatform, SpawnNext.position, Quaternion.identity).transform;
       FirstPlatform = nextPlatformPos;

    }


}
