using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
	public float speed;
    public float time = 1;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed * time;
	}
}
