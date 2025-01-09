using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public GameObject cloud1;
    public GameObject cloud2;
    public float speed = 10f;
    public Vector3[] initalPos = new Vector3[100];
    public GameObject[] clouds = new GameObject[100];

    void Start()
    {
        

        for (int i = 0; i < 50; i++)
        {
            Quaternion rotation = Quaternion.Euler(0, Random.Range(0f, 360f), 0);
            Vector3 pos = new Vector3(Random.Range(-20f, 20f), Random.Range(10f, 15f), Random.Range(-100f, 150f));
            clouds[i] = Instantiate(cloud1, pos, rotation);
            initalPos[i] = pos;
        }
        for (int i = 50; i < 100; i++)
        {
            Quaternion rotation = Quaternion.Euler(0, Random.Range(0f, 360f), 0);
            Vector3 pos = new Vector3(Random.Range(-20f, 20f), Random.Range(10f, 15f), Random.Range(-100f, 150f));
            clouds[i] = Instantiate(cloud2, pos, rotation);
            initalPos[i] = pos;
        }


    }
    void Update()
    {
        //for (int i = 0; i < clouds.Length; i++)
        //{
        //    Vector3 move = new Vector3(Random.Range(-50f, 50f), 0f, Random.Range(-150f, 150f));
        //    clouds[i].transform.position = Vector3.MoveTowards(initalPos[i], move, speed * Time.deltaTime);
        //}

    }

}
