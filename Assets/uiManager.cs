using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;

public class uiManager : MonoBehaviour
{

    //public TMP_Text speedText;
    public TMP_Text bestSpeed;
    //public string text1;
    public string text2;
    public string text3;

    public TMP_Text finish;

    public static float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //text1 = "Speed: " + time;
        text2 = "Best Time: " + Runner.timeBest;
        text3 = "";
    }

    // Update is called once per frame
    void Update()
    {

        if (!ChildSpawn.record)
        {
            time = 0f;
        }
        else
        {
            time = ChildSpawn.timeSpawned;
        }
        //text1 = "Speed: " + time;
        text2 = "Best Time: " + Runner.timeBest;

        //speedText.text = text1;
        bestSpeed.text = text2;

        if (HitDetector.done)
        {
            text3 = "Congratulations, you finished!!!";
            finish.text = text3;
        

        }

    }
}
