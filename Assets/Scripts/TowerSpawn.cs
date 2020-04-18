using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    public GameObject TowerBase;
    public GameObject MidFloor;
    public GameObject TowerFloor;
    public GameObject TowerFloor1;
    public GameObject TowerFloor2;

    public GameObject Empty;
    private GameObject currentEmpty;

    int numberOfTowers = 5;
    Vector3[] spawnPoints;
    GameObject[] tower;

    public Transform BuildingHolder;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = new Vector3[6];

        for (int i = 0; i < numberOfTowers; i ++)
        {
            spawnPoints[i] = new Vector3(Random.Range(-30, 30), 0.0f, Random.Range(-30, 30));
        }

        float xPos = -2.5f;
        float yPos = 1.5f;
        float zPos = 30.0f;

        for (int i = 0; i < numberOfTowers; i++)
        {
            int towerSize = Random.Range(5, 20);
            // random tower size
            tower = new GameObject[towerSize];

            tower[0] = TowerBase;
            for (int j = 1; j < towerSize; j++)
            {
                int floorIndex = Random.Range(1, 4);
                // random floor type

                if (floorIndex == 1)
                {
                    tower[j] = TowerFloor;
                }
                else if (floorIndex == 2)
                {
                    tower[j] = TowerFloor1;
                }
                else if (floorIndex == 3)
                {
                    tower[j] = TowerFloor2;
                }
            }
            // populating the array with the tower pieces

            currentEmpty = Instantiate(Empty, BuildingHolder) as GameObject;
            currentEmpty.name = "Tower " + i; // naming game objects

            for (int k = 0; k < towerSize; k++)
            {
                Instantiate(tower[k], new Vector3(xPos, yPos, zPos), Quaternion.identity, currentEmpty.transform);
                yPos += 1.1f;
            }
            // spawning the tower

            if (i % 2 == 0)
            {
                xPos = -2.5f;
                yPos = 1.5f;
                zPos += 15.0f;
            }
            else
            {
                xPos += 5.0f;
                yPos = 1.5f;
            }
            // moving towers along x axis


        }
        // creating multiple towers
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
