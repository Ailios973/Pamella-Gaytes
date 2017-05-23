using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchMeAndPlay : MonoBehaviour
{

    public GameObject entry1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            entry1.SetActive(true);
            Time.timeScale = 0;
        }
    }

}

