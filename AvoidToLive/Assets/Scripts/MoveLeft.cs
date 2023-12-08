using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10;
    private float leftBound = -10;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left *Time.deltaTime * speed);
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
