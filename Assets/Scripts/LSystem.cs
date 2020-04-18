using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSystem : MonoBehaviour
{
    public GameObject plantBase;
    public GameObject[] plant;

    int numOfGenerations = 2;

    string axiom = "AL";
    string rule = "LLR";

    char[] finalString;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numOfGenerations; i++)
        {
            axiom = axiom.Replace("L", rule);
        }
        // L System
        
        Debug.Log(axiom);

        //spawning plant in accoridng to L 
        finalString = new char[axiom.Length];
        finalString = axiom.ToCharArray();

        plant = new GameObject[finalString.Length];

        for (int i = 0; i < plant.Length; i++)
        {
            plant[i] = plantBase;
        }

        float xPos = -15.0f;
        float yPos = 0.5f;
        float zPos = -10.0f;

        for (int i = 0; i < finalString.Length; i++)
        {
            if (finalString[i] == 'A')
            {
                GameObject newPlant = Instantiate(plant[i], new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
            }

            if (finalString[i] == 'L')
            {
                //GameObject newPlant = Instantiate(plant[i], new Vector3(xPos + (1 * (i + 1)), yPos, zPos), Quaternion.identity) as GameObject;
                GameObject newPlant = Instantiate(plant[i], new Vector3(xPos, yPos + (1 * (i + 1)), zPos), new Quaternion(0, 0, 0, 0)) as GameObject;
                //newPlant.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }

            if (finalString[i] == 'R')
            {
                GameObject newPlant = Instantiate(plant[i], new Vector3(xPos, yPos + (1 * (i + 1)), zPos), new Quaternion(0, 90, 0, 0)) as GameObject;
                //newPlant.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
