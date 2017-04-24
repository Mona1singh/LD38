using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScript : MonoBehaviour {

    public Canvas canvas;
    public bool pauseopen;
    
    void Start()
    {
        canvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!pauseopen)
            {
                Time.timeScale = 0;
                pauseopen = !pauseopen;
                canvas.enabled = true;
            }
            else
            {
                Time.timeScale = 1;
                pauseopen = !pauseopen;
                canvas.enabled = false;

            }
        }


    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }

}
