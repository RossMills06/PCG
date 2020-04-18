using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockSpanwer : MonoBehaviour
{
    public GameObject rock1;
    public GameObject rock2;

    GameObject[] rockset1;
    int numberOfRockset1 = 10;
    Vector3[] rockset1pos;

    // Start is called before the first frame update
    void Start()
    {
        rockset1 = new GameObject[numberOfRockset1];

        rockset1pos = new Vector3[5];
        rockset1pos[0] = new Vector3(Random.Range(-100, 100), 0.2f, Random.Range(0, 200));
        rockset1pos[1] = new Vector3(Random.Range(-100, 100), 0.2f, Random.Range(0, 200));
        rockset1pos[2] = new Vector3(Random.Range(-100, 100), 0.2f, Random.Range(0, 200));
        rockset1pos[3] = new Vector3(Random.Range(-100, 100), 0.2f, Random.Range(0, 200));
        rockset1pos[4] = new Vector3(Random.Range(-100, 100), 0.2f, Random.Range(0, 200));

        for (int i = 0; i < rockset1pos.Length; i++)
        {
            if (rockset1pos[i].x < 7.5 && rockset1pos[i].x > - 7.5)
            {
                rockset1pos[i].x = Random.Range(-100, 100);
            }
            // getting a new x value if it lies too close to the road
        }

        for (int i = 0; i < numberOfRockset1; i++)
        {
            int rockIndex = Random.Range(0, 2);
            if (rockIndex == 0)
                rockset1[i] = rock1;
            else if (rockIndex == 1)
                rockset1[i] = rock2;


            float xPos = rockset1pos[0].x + Random.Range(-7.5f, 7.5f);
            float yPos = rockset1pos[0].y;
            float zPos = rockset1pos[0].z + Random.Range(-7.5f, 7.5f);

            Instantiate(rockset1[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        }

        for (int i = 0; i < numberOfRockset1; i++)
        {
            int rockIndex = Random.Range(0, 2);
            if (rockIndex == 0)
                rockset1[i] = rock1;
            else if (rockIndex == 1)
                rockset1[i] = rock2;

            float xPos = rockset1pos[1].x + Random.Range(-7.5f, 7.5f);
            float yPos = rockset1pos[1].y;
            float zPos = rockset1pos[1].z + Random.Range(-7.5f, 7.5f);

            Instantiate(rockset1[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        }

        for (int i = 0; i < numberOfRockset1; i++)
        {
            int rockIndex = Random.Range(0, 2);
            if (rockIndex == 0)
                rockset1[i] = rock1;
            else if (rockIndex == 1)
                rockset1[i] = rock2;

            float xPos = rockset1pos[2].x + Random.Range(-7.5f, 7.5f);
            float yPos = rockset1pos[2].y;
            float zPos = rockset1pos[2].z + Random.Range(-7.5f, 7.5f);

            Instantiate(rockset1[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        }

        for (int i = 0; i < numberOfRockset1; i++)
        {
            int rockIndex = Random.Range(0, 2);
            if (rockIndex == 0)
                rockset1[i] = rock1;
            else if (rockIndex == 1)
                rockset1[i] = rock2;

            float xPos = rockset1pos[3].x + Random.Range(-7.5f, 7.5f);
            float yPos = rockset1pos[3].y;
            float zPos = rockset1pos[3].z + Random.Range(-7.5f, 7.5f);

            Instantiate(rockset1[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        }

        for (int i = 0; i < numberOfRockset1; i++)
        {
            int rockIndex = Random.Range(0, 2);
            if (rockIndex == 0)
                rockset1[i] = rock1;
            else if (rockIndex == 1)
                rockset1[i] = rock2;

            float xPos = rockset1pos[4].x + Random.Range(-7.5f, 7.5f);
            float yPos = rockset1pos[4].y;
            float zPos = rockset1pos[4].z + Random.Range(-7.5f, 7.5f);

            Instantiate(rockset1[i], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
