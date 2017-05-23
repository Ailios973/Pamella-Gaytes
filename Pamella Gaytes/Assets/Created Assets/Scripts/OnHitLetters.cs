using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitLetters : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.name == "Player")
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }

}
