using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthChooser : MonoBehaviour {

    private Vector3 Start1;
    private Vector3 Start2;
    private Vector3 Start3;
    private Vector3 Start4;
    private Vector3 Start5;

    public GameObject Char;

    // Use this for initialization
    void Start ()
    {
        Start1 = new Vector3(-14.9f, 0.0f, 62.79f);
        Start2 = new Vector3(-14.83f, 0.0f, 14.83f);
        Start3 = new Vector3(15.02f, 0.0f, -2.8f);
        Start4 = new Vector3(-14.8f, 0.0f, -14.8f);
        Start5 = new Vector3(14.93f, 0.0f, -2.85f);

        //Char = new GameObject("Exemple");


    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
