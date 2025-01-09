using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManage : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (HitDetector.done)
        {
            cam1.enabled = false;
            cam2.enabled = true;
            transform.Rotate(0f, speed * Time.deltaTime, 0f);
        }
    }
}
