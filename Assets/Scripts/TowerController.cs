using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;
    public GameObject tower4;
    public GameObject tower5;
    public GameObject finishLine;

    public GameObject cart1;
    public GameObject cart2;
    public GameObject cart3;
    public GameObject cart4;
    public GameObject cart5;

    public float speed1 = 0.2f;
    public float speed2 = 0.2f;
    public float speed3 = 0.2f;
    public float speed4 = 0.2f;
    public float speed5 = 0.2f;

    bool movement = false;

    // Start is called before the first frame update
    void Start()
    {
        cart1 = Instantiate(cart1, new Vector3(-2.5f, 0.5f, 30.0f), Quaternion.identity);
        cart2 = Instantiate(cart2, new Vector3(-2.5f, 0.5f, 45.0f), Quaternion.identity);
        cart3 = Instantiate(cart3, new Vector3(2.5f, 0.5f, 45.0f), Quaternion.identity);
        cart4 = Instantiate(cart4, new Vector3(-2.5f, 0.5f, 60.0f), Quaternion.identity);
        cart5 = Instantiate(cart5, new Vector3(2.5f, 0.5f, 60.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (tower1 == null)
        {
            tower1 = GameObject.Find("Tower 0");
        }

        if (tower2 == null)
        {
            tower2 = GameObject.Find("Tower 1");
        }

        if (tower3 == null)
        {
            tower3 = GameObject.Find("Tower 2");
        }

        if (tower4 == null)
        {
            tower4 = GameObject.Find("Tower 3");
        }

        if (tower5 == null)
        {
            tower5 = GameObject.Find("Tower 4");
        }

        if (finishLine == null)
        {
            finishLine = GameObject.Find("Finish Marker(Clone)");
        }

        

        if (Input.GetKeyDown("space"))
        {
            movement = !movement;
        }

        Debug.Log(movement);

        if (movement == true)
        {
            cart1.transform.position += new Vector3(0.0f, 0.0f, speed1);
            cart2.transform.position += new Vector3(0.0f, 0.0f, speed2);
            cart3.transform.position += new Vector3(0.0f, 0.0f, speed3);
            cart4.transform.position += new Vector3(0.0f, 0.0f, speed4);
            cart5.transform.position += new Vector3(0.0f, 0.0f, speed5);

            tower1.transform.position += new Vector3(0.0f, 0.0f, speed1);
            tower2.transform.position += new Vector3(0.0f, 0.0f, speed2);
            tower3.transform.position += new Vector3(0.0f, 0.0f, speed3);
            tower4.transform.position += new Vector3(0.0f, 0.0f, speed4);
            tower5.transform.position += new Vector3(0.0f, 0.0f, speed5);

            float speedChange1 = Random.Range(-0.02f, 0.02f);
            float speedChange2 = Random.Range(-0.02f, 0.02f);
            float speedChange3 = Random.Range(-0.02f, 0.02f);
            float speedChange4 = Random.Range(-0.02f, 0.02f);
            float speedChange5 = Random.Range(-0.02f, 0.02f);

            int doSpeedChange = Random.Range(0, 8);
            if (doSpeedChange == 3)
            {
                speed1 += speedChange1;
                speed2 += speedChange2;
                speed3 += speedChange3;
                speed4 += speedChange4;
                speed5 += speedChange5;
            }

            //limiting speed
            if (speed1 <= 0)
                speed1 = 0;
            if (speed2 <= 0)
                speed2 = 0;
            if (speed3 <= 0)
                speed3 = 0;
            if (speed4 <= 0)
                speed4 = 0;
            if (speed5 <= 0)
                speed5 = 0;

            if (speed1 >= 0.8f)
                speed1 = 0.4f;
            if (speed2 >= 0.8f)
                speed2 = 0.4f;
            if (speed3 >= 0.8f)
                speed3 = 0.4f;
            if (speed4 >= 0.8f)
                speed4 = 0.4f;
            if (speed5 >= 0.8f)
                speed5 = 0.4f;


            // checking towers dont hit each other (works like a rubberband/spring)
            // speed up/slow down when towers get too close
            // tower 4      tower 5 
            // tower 2      tower 3
            // tower 1
            if (tower2.transform.position.z - tower1.transform.position.z < 7)
            {
                if (tower2.transform.position.z - tower1.transform.position.z <= 0.5f)
                {
                    speed1 -= 0.05f;
                    speed3 += 0.008f;
                }

                speed1 -= 0.0005f;
                speed2 += 0.0005f;
            }

            if (tower4.transform.position.z - tower2.transform.position.z < 7)
            {
                if (tower4.transform.position.z - tower2.transform.position.z <= 0.5f)
                {
                    speed2 -= 0.05f;
                    speed4 += 0.008f;
                }

                speed2 -= 0.0008f;
                speed4 += 0.008f;
            }

            if (tower5.transform.position.z - tower3.transform.position.z < 7)
            {
                if (tower5.transform.position.z - tower3.transform.position.z <= 0.5)
                {
                    speed3 -= 0.05f;
                    speed5 += 0.008f;
                    Debug.Log("WOW");
                }

                speed5 += 0.008f;
                speed3 -= 0.0008f;
            }

            // checking towers aren't too far apart
            if (tower2.transform.position.z - tower1.transform.position.z > 9)
            {
                speed1 += 0.008f;
                speed2 -= 0.0008f;
            }

            if (tower4.transform.position.z - tower2.transform.position.z > 9)
            {
                speed2 += 0.008f;
                speed4 -= 0.0008f;
            }

            if (tower5.transform.position.z - tower3.transform.position.z > 9)
            {
                speed5 -= 0.0008f;
                speed3 += 0.008f;
            }
        }

        // checking if towers reach the finish
        //if (finishLine != null && movement == true)
        //{
        //    if (tower4.transform.position.z > finishLine.transform.position.z || tower5.transform.position.z > finishLine.transform.position.z)
        //    {
        //        cart1.transform.position = new Vector3(-2.5f, 0.5f, 30.0f);
        //        cart2.transform.position = new Vector3(-2.5f, 0.5f, 45.0f);
        //        cart3.transform.position = new Vector3(2.5f, 0.5f, 45.0f);
        //        cart4.transform.position = new Vector3(-2.5f, 0.5f, 60.0f);
        //        cart5.transform.position = new Vector3(2.5f, 0.5f, 60.0f);

        //        tower1.transform.position = new Vector3(-2.5f, 1.5f, 30.0f);
        //        tower2.transform.position = new Vector3(-2.5f, 1.5f, 45.0f);
        //        tower3.transform.position = new Vector3(2.5f, 1.5f, 45.0f);
        //        tower4.transform.position = new Vector3(-2.5f, 1.5f, 60.0f);
        //        tower5.transform.position = new Vector3(2.5f, 1.5f, 60.0f);

        //        speed1 = 0.2f;
        //        speed2 = 0.2f;
        //        speed3 = 0.2f;
        //        speed4 = 0.2f;
        //        speed5 = 0.2f;

        //        Debug.Log("TEST");
        //    }
        //}

    }
}
