using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{

    public GameObject tree;
    public GameObject tree2;
    GameObject[] trees;
    Vector3[] spawnCluster = new Vector3[25];

    int numberOfTrees;

    bool treesSpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        numberOfTrees = Random.Range(400, 600);
        trees = new GameObject[numberOfTrees];

        for (int i = 0; i < spawnCluster.Length; i++)
        {
            spawnCluster[i] = new Vector3(Random.Range(-80, 80), 1.0f, Random.Range(-10, 600));
            // generating random spawn points
        }


        //spawning trees randomly
        //for (int i = 0; i < numberOfTrees; i++)
        //{
        //    trees[i] = tree;
        //    float xPos = Random.Range(-80, 80);
        //    float yPos = 1.0f;
        //    float zPos = Random.Range(0, 200);

        //    if (xPos > 10.0f || xPos < -10)
        //    {
        //        Instantiate(trees[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        //    }
        //    else
        //    {
                
        //    }
        //}

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < spawnCluster.Length; i++)
        {
            if (spawnCluster[i].x < 25 && spawnCluster[i].x > -25)
            {
                if (spawnCluster[i].x < 0)
                {
                    spawnCluster[i].x -= 30;
                }
                else if (spawnCluster[i].x >= 0)
                {
                    spawnCluster[i].x += 30;
                }
                // getting new x value if it lies too close to the road
            }
        }


        if (treesSpawned == false)
        {
            for(int i = 0; i < numberOfTrees; i ++)
            {
                int treeIndex = Random.Range(0, 3);
                if (treeIndex == 0)
                {
                    trees[i] = tree2;
                }
                else
                {
                    trees[i] = tree;
                }
                // selecting which tree to use
                

                int clusterIndex = Random.Range(0, 25);

                float xPos = spawnCluster[clusterIndex].x + Random.Range(-15, 15);
                float yPos = spawnCluster[clusterIndex].y;
                float zPos = spawnCluster[clusterIndex].z + Random.Range(-15, 15);

                Instantiate(trees[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);

               // Debug.Log(spawnCluster[clusterIndex].x);
            }

            treesSpawned = true;
        }
    }

    Vector3 testSpawnPoints(Vector3 spawnPoints)
    {
        if (spawnPoints.x < 35 && spawnPoints.x > -35)
        {
            spawnPoints.x = Random.Range(-100, 100);
        }
        else
        {
            return spawnPoints;
        }

        Debug.Log(spawnPoints.x);
        //testSpawnPoints(spawnPoints);

        return testSpawnPoints(spawnPoints);
    }
    // recursive fucntion to test whether spawn point lies too close to the road
}
