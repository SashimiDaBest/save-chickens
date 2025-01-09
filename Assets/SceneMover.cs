using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (Input.GetKey(KeyCode.Space) && sceneName == "IntroScene")
        {
            SceneManager.LoadScene("PlayScene");
        }
        if (Input.GetKey(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        if (HitDetector.done == true && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("PlayScene");
            HitDetector.done = false;
        }
    }
}
