using UnityEngine;
using System.Collections;

public class Controll2D : MonoBehaviour {
    public float godspeed = 20f;
    private Rigidbody rig;
    

	// Use this for initialization
	void Start ()
    {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float axeh = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(axeh, 0, 0) * godspeed * Time.deltaTime;
        rig.MovePosition(transform.position + movement);

    }
}
