using UnityEngine;
using System.Collections;

public class Controll2D : MonoBehaviour {
    public float godspeed = 20f;
    public float jumpSpeed = 100f;
    private bool onGround = false;
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

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rig.AddForce(Vector3.up * jumpSpeed);
        }
    }
    private void OnCollisionStay()
    {
        onGround = true;
    }
    private void OnCollisionEnter(Collision col)
    {
        if ( col.gameObject.tag == "Obstacle")
        {
            transform.position = new Vector3(-16f, 51, 0.07f);
        }
        if (col.gameObject.tag == "Lettres")
        {
            col.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
 
  
 
}
