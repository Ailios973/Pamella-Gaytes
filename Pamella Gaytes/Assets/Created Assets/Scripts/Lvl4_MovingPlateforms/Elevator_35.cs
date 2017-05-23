using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_35 : MonoBehaviour {
    private bool down;
    private float inity;
	void Start ()
    {
        inity = transform.position.y;
        down = true;
	}
	
	void Update ()
    {
        if (down)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 2, Space.World);
            if (inity + 35.25 - transform.position.y <= 0)//change the 10.25 to have a new elevator, but in an other C# script
                down = false;
        }
        if (!down)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 2, Space.World);
            if (transform.position.y - inity <= 0)
                down = true;
        }
	}
}
