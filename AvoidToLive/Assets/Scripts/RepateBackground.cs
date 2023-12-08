using UnityEngine;

public class RepateBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repateWidth;

    void Start()
    {
        startPosition = transform.position;
        repateWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        if (transform.position.x < startPosition.x - repateWidth)
        {
            transform.position = startPosition;
        }
    }
}
