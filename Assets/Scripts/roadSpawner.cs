using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadSpawner : MonoBehaviour
{
    public GameObject roadStraight;
    public GameObject[] road;

    public GameObject finishMarker;

    private int roadLength;
    public Vector3 roadEndPoint;

    // Start is called before the first frame update
    void Start()
    {
        roadLength = Random.Range(20, 30);
        //roadLength = 20;

        road = new GameObject[roadLength];
        
        for (int i = 0; i < roadLength; i++)
        {
            road[i] = roadStraight;
        }
        // populating road array

        float xPos = 0.0f;
        float yPos = 0.0f;
        float zPos = -100.0f;

        for (int i = 0; i < roadLength; i++)
        {
            Instantiate(road[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            zPos += 40.0f;
        }

        roadEndPoint = new Vector3(0.0f, 8.0f, (zPos - 40.0f));

        Instantiate(finishMarker, roadEndPoint, Quaternion.identity);
    }

    // make prefab of road with floor maybe?, or just one big floor?

    // Update is called once per frame
    void Update()
    {
        
    }
}
