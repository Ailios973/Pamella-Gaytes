using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ShooterPauser : MonoBehaviour {

    public Transform canvas;

    public GameObject player;
    public GameObject background;
    public GameObject gameController;

    [SerializeField]
    string scene = SceneManager.GetActiveScene().ToString();

	// Update is called once per frame
	void Update ()
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
                player.GetComponent<Done_PlayerController>().enabled = false;
                background.GetComponent<Done_BGScroller>().enabled = false;
                gameController.GetComponent<AudioSource>().enabled = false;

            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
                player.GetComponent<Done_PlayerController>().enabled = true;
                background.GetComponent<Done_BGScroller>().enabled = true;
                gameController.GetComponent<AudioSource>().enabled = true;
            }
        }
    }
    public void GoToHub()
    {
        SceneManager.LoadScene(0);
        player.GetComponent<Done_PlayerController>().enabled = true;
        background.GetComponent<Done_BGScroller>().enabled = true;
        gameController.GetComponent<AudioSource>().enabled = true;
        Time.timeScale = 1;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        player.GetComponent<Done_PlayerController>().enabled = true;
        background.GetComponent<Done_BGScroller>().enabled = true;
        gameController.GetComponent<AudioSource>().enabled = true;
        Time.timeScale = 1;
    }
    public void IQuit()
    {
        Application.Quit();
    }
}
