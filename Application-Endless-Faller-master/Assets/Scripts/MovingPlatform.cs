using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed=2.0f;

    private bool ScoreAdded=false;
    private Transform player;
    private LevelManager lm;
    void Start()
    {
        player = FindObjectOfType<MainCharacter>().transform;
        lm = FindObjectOfType<LevelManager>();
        speed = lm.speed;
        lm.IncreaseSpeed();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.timeScale * 0.005f * speed);
       
        if (gameObject.transform.position.y > 10.0f)
        {
            Destroy(gameObject);
        }

        addScore();

    }

    void addScore()
    {

        if (player.position.y < gameObject.transform.position.y && ScoreAdded == false)
        {
            FindObjectOfType<LevelManager>().IncrementScore();
            ScoreAdded = true;
        }
    }



}