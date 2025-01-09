using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class SpawnGrass : MonoBehaviour
{
    public GameObject[] isTree;
    public GameObject grass;
    private float[] posWeight = new float[3];
    public int count2 = 0;

    public GameObject santa;
    public float startPos;
    public GameObject snow;

    public int count = 0;

    void Start()
    {
        santa = GameObject.Find("Santa");
        startPos = santa.transform.position.z;
        isTree = GameObject.FindGameObjectsWithTag("tree");

    }

    void Update()
    {
        int numObj = GameObject.FindGameObjectsWithTag("tree").Length;
        while (count2 < (numObj-1))
        {
            foreach (GameObject treeOne in isTree)
            {
                for (int i = 0; i < 3; i++)
                {
                    posWeight[i] = Random.Range(-5.0f, 5.0f);
                    Instantiate(grass, new Vector3(treeOne.transform.position.x + posWeight[i], treeOne.transform.position.y, treeOne.transform.position.z + posWeight[i]), treeOne.transform.rotation);
                }
                count2++;
            }
        }


        if (count == 0)
        {
            Instantiate(snow, snow.transform.position, snow.transform.rotation);
            count++;
        }
        else if (count == 1)
        {
            if ((santa.transform.position.z - startPos) > 30f)
            {
                startPos = santa.transform.position.z;
                Vector3 pos = new Vector3(snow.transform.position.x, snow.transform.position.y, santa.transform.position.z + 100f);
                Instantiate(snow, pos, snow.transform.rotation);
                count++;
            }
        }
        else if (count == 2)
        {
            if ((santa.transform.position.z - startPos) > 90f)
            {
                startPos = santa.transform.position.z;
                Vector3 pos = new Vector3(snow.transform.position.x, snow.transform.position.y, santa.transform.position.z + 100f);
                Instantiate(snow, pos, snow.transform.rotation);
                count++;
            }
        }

    }
}