using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            transform.position += Vector3.up *0.005f*speed;

        if (gameObject.transform.position.y > 10.0f)
        {
            Destroy(gameObject);
        }
    }

}