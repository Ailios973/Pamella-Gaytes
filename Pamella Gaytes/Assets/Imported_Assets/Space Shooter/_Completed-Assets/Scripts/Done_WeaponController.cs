using UnityEngine;
using System.Collections;

public class Done_WeaponController : MonoBehaviour
{
	public GameObject shot;
	public Transform shotSpawn;
    public Transform shotSpawn1;
    public bool morethanone;

    public float fireRate;
	public float delay;
    

	void Start ()
	{
		InvokeRepeating ("Fire", delay, fireRate);
	}

	void Fire ()
	{
        if (morethanone)
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            Instantiate(shot, shotSpawn1.position, shotSpawn1.rotation);
            GetComponent<AudioSource>().Play();
        }
        else
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            GetComponent<AudioSource>().Play();
        }
            
        
		
	}
}
