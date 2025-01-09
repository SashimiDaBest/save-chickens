using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    //public ParticleSystem part;
    public GameObject santa;
    public static bool done = false;

    // Update is called once per frame


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "child") //if collide, destroy chicken
        {
            Destroy(GameObject.FindWithTag("child"));
        }

        if (collision.gameObject.name == "finishLine") //if collide, stop cube, and spin camera
        {
            Runner.speed = 0f;
            done = true;
            //Application.Quit();
        }
    }
}
