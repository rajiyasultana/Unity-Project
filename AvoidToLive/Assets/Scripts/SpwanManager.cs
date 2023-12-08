using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject obstaclePrefeb;
    private Vector3 spwanPos = new Vector3(25, 0, 0);
    private float startdelay = 2;
    private float repateWidth = 2;
    void Start()
    {
        InvokeRepeating("SpwanObstacle", startdelay, repateWidth);
    }

    // Update is called once per frame
    void SpwanObstacle()
    {
        Instantiate(obstaclePrefeb, spwanPos, obstaclePrefeb.transform.rotation);
    }
}
