using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : MonoBehaviour
{
    public Text speedText;
    public string speedtext;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speedtext = "Time: " + speed;
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime;
        speedtext = "Time: " + speed;
        speedText.text = speedtext;
    }
}
