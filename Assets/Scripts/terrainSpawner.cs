using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrainSpawner : MonoBehaviour
{
    public GameObject terrainLeft1;
    public GameObject terrainRight1;

    public GameObject[] leftTerrain;
    public GameObject[] rightTerrain;

    // Start is called before the first frame update
    void Start()
    {
        leftTerrain = new GameObject[2];
        rightTerrain = new GameObject[2];

        float xPos = -500.0f;
        float yPos = -0.1f;
        float zPos = 0.0f;

        for (int i = 0; i < leftTerrain.Length; i++)
        {
            leftTerrain[i] = terrainLeft1;
            Instantiate(leftTerrain[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);

            zPos += 500.0f;
        }

        xPos = -100.0f;
        yPos = -0.1f;
        zPos = 0.0f;

        for (int i = 0; i < rightTerrain.Length; i++)
        {
            rightTerrain[i] = terrainRight1;
            Instantiate(rightTerrain[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);

            zPos += 500.0f;
        }


        //Instantiate(terrainLeft1, new Vector3(-500.0f, -0.1f, 0.0f), Quaternion.identity);
        //Instantiate(terrainRight1, new Vector3(-100.0f, -0.1f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
