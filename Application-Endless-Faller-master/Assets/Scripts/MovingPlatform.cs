using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed=2.0f;
    private bool touched;
    public GameObject player;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            transform.position += Vector3.up *0.005f*speed*Time.timeScale;

        if (gameObject.transform.position.y > 10.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colisao");
        if (collision.gameObject.CompareTag("Player") && !touched)
        {
            touched = true;
            FindObjectOfType<LevelManager>().IncrementScore();
        }
    }

}