using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{
    public GameObject Plane;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Plane, new Vector3(0.0f, -0.001f, 0.0f), Quaternion.identity);
        Instantiate(Plane, new Vector3(0.0f, -0.001f, 700.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
