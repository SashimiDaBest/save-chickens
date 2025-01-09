using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{

    public static float speed = 10f;
    int count = 0; //starting setting
    public GameObject santa;

    public Vector3 oldPosition;
    public float speedLog;
    public static bool speeding = true;

    public static float timeReact = 0f;
    public static float timeBest = 0f;
    public static int num = 0;

    void Start()
    {
        oldPosition = santa.transform.position;
    }

    void FixedUpdate()
    {
        speedLog = Vector3.Distance(oldPosition, santa.transform.position) * 100f;
        //Debug.Log("Speed: " + speedLog.ToString("F2"));
        oldPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime); //player move

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(count == 0) //if paused, their speed is 0, 
            {
                speed = 0f;
                timeReact = ChildSpawn.timeSpawned;
                StopRecording();
                count++;
            
            }
            else if (count == 1) //if press play, speed resumes
            {
                speed = 10f;
                count = 0;
                num -= 1;
            }
            
        }

        if (speedLog == 0) //determine if cube is moving
        {
            speeding = false;
        }
        else
        {
            speeding = true;
        }


        if (ChildSpawn.record) //if is recording, time = ...
        {
            ChildSpawn.timeSpawned += 1 * Time.deltaTime;
            if(ChildSpawn.timeSpawned >= 0.6)
            {
                Destroy(GameObject.FindWithTag("child"));
                StopRecording();
            }
        }
    }

    static void StopRecording()
    {
        ChildSpawn.record = false;
        ChildSpawn.timeSpawned = 0f;
        if (num == 0 || timeBest == 0)
        {
            timeBest = timeReact;
        }
        else if (num < 0 && timeReact < timeBest && (timeReact != 0 && timeReact > 0.09))
        {
            timeBest = timeReact;
            //Time.time * 1000 = milliseconds
        }
    }
}
