using UnityEngine;
using System.Collections;

[System.Serializable]
public class Done_Boundary 
{
	public float xMin, xMax, zMin, zMax;
}

public class Done_PlayerController : MonoBehaviour
{
	public float speed;
	public float tilt;
	public Done_Boundary boundary;

	public GameObject shot;
	public Transform shotSpawn;
    public Transform shotSpawnBonus1;
    public Transform shotSpawnBonus2;
    public Transform shotSpawnBonus3;
    public Transform shotSpawnBonus4;
    public float fireRate;
    public bool bonus1;
    public bool bonus2;
    public int damage = 10;
	 
	private float nextFire;
	
	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire) 
		{
            BossHP bossHP = shot.GetComponent<Collider>().GetComponent<BossHP>();
			nextFire = Time.time + fireRate;
            if (bonus1 == true)
            {
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                Instantiate(shot, shotSpawnBonus1.position, shotSpawnBonus1.rotation);
                Instantiate(shot, shotSpawnBonus2.position, shotSpawnBonus2.rotation);
                if(bossHP != null)
                {
                    bossHP.TakeDamage(damage, shot.GetComponent<Collider>() , shot.transform.position);
                }
                if (bonus2 == true)
                {
                    Instantiate(shot, shotSpawnBonus3.position, shotSpawnBonus3.rotation);
                    Instantiate(shot, shotSpawnBonus4.position, shotSpawnBonus4.rotation);
                }
                GetComponent<AudioSource>().Play();
            }
            else
            {
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                GetComponent<AudioSource>().Play();
            }
			
		}
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().velocity = movement * speed;
		
		GetComponent<Rigidbody>().position = new Vector3
		(
			Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
		);
		
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
	}
}
