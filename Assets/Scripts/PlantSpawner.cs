using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSpawner : MonoBehaviour
{
    public GameObject plant1;

    int numberOfPlants;

    // Start is called before the first frame update
    void Start()
    {
        numberOfPlants = Random.Range(50, 150);


        for (int i = 0; i < numberOfPlants; i++)
        {
            float xPos = Random.Range(-100, 100);
            float yPos = 0.0f;
            float zPos = Random.Range(-10, 500);
            if (xPos < 15 && xPos > -15)
            {
                if (xPos > 0)
                    xPos += 20;
                else if (xPos <= 0)
                    xPos -= 20;
            }
            // adjusting xPos if it lies too close to road

            Instantiate(plant1, new Vector3(xPos, yPos, zPos), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
