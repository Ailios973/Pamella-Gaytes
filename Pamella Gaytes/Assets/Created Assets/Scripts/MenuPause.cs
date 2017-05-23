using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


public class MenuPause : MonoBehaviour
{
    public Transform canvas;
    public Transform player;
    private string scene = SceneManager.GetActiveScene().ToString();
    
    void Update()
    {
        Pause();
    }
    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
                player.GetComponent<Controll2D>().enabled = false;
                player.GetComponent<Done_PlayerController>().enabled = false;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
                player.GetComponent<Controll2D>().enabled = true;
                player.GetComponent<Done_PlayerController>().enabled = true;
            }
        }
    }
    public void GoToHub()
    {
        SceneManager.LoadScene(0);
        player.GetComponent<Controll2D>().enabled = true;
        player.GetComponent<Done_PlayerController>().enabled = true;
        Time.timeScale = 1;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        player.GetComponent<Controll2D>().enabled = true;
        player.GetComponent<Done_PlayerController>().enabled = true;
        Time.timeScale = 1;
    }
    public void IQuit()
    {
        Application.Quit();
    }
}
