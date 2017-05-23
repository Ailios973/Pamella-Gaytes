using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_Repop : MonoBehaviour {
    public Vector3 SpawnPoint;
    public Transform player;
    void OnTriggerEnter ()
    {
            player.transform.position = SpawnPoint;
 
	}
}
