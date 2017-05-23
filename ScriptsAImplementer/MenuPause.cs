using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MenuPause : MonoBehaviour {

    private bool isPaused = false;
    
    
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
            isPaused = !isPaused;

        if (isPaused)
            Time.timeScale = 0f;

        else
            Time.timeScale = 1.0f;
	}
	
	
	void OnGUI () {

        if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 - 100, 120, 80),"Continue"))
            isPaused = false;
        if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 0, 120, 80), "Return to HUB"))
            Application.LoadLevel("hub");   //Replace "hub" by hub
        if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 100, 120, 80),"Quit"))
            Application.Quit();


    }
}
