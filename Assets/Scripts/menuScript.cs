using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

    public string sceneName;

    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene(1);
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
