using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildSpawn : MonoBehaviour
{
    public GameObject santa;
    public GameObject child;

    public static bool record = false;
    public static float timeSpawned;

    float maxTime = 1000f;
    float currentTime = 0f;
    float timeTillSpawn;

    void Start()
    {
        timeSpawned = 0f;
    }

    void Update()
    {
        timeTillSpawn = Random.Range(0, maxTime);
        currentTime += Time.deltaTime;

        //if chicken is past cube, cube is moving, and the time is not recording
        if (currentTime > timeTillSpawn && Runner.speeding && record == false &&  GameObject.FindWithTag("child") == null && !HitDetector.done)
        {
            wait();
            Spawn();
        }

    }

    void Spawn() //create chicken 5 units infront of cube + start recording
    {
        Vector3 santaPos = santa.transform.position;
        if(santa.transform.position.z != 140)
        {
            Vector3 spawnPos = new Vector3(santaPos.x, 0.5f, santaPos.z + 10f);
            Instantiate(child, spawnPos, Quaternion.Euler(0, 180f, 0));
            currentTime = 0;
            StartRecord();
        }

    }



    public static void StartRecord()
    {
        record = true;
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5); //wait 5s before execute next line of code 
    }

}
