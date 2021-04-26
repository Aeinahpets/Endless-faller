using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed=2.0f;
    private bool ScoreAdded=false;
    public Transform player;

    void Start()
    {
        player = FindObjectOfType<MainCharacter>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Time.timeScale * 0.005f * speed;

        if (gameObject.transform.position.y > 10.0f)
        {
            Destroy(gameObject);
        }

        if(player.position.y < gameObject.transform.position.y && ScoreAdded==false)
        {
            FindObjectOfType<LevelManager>().IncrementScore();
            ScoreAdded = true;
        }


    }

    

}