using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public float impactForce;
    public float fireRate = 15f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    //public GameObject impact;

    private float nextTImeToFire = 0f;

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTImeToFire)
        {
            nextTImeToFire = Time.time + 1f / fireRate;
            Shoot();
        }                

    }

    void Shoot()
    {

        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                Debug.Log(hit.transform.name);
                target.TakeDamage(damage);

            }

            if (hit.rigidbody != null)
            {
                target.TakeDamage(damage);
                hit.rigidbody.AddForce(-hit.normal * impactForce);

            }

            //GameObject Impact = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
            //Destroy(Impact, 2f);
        }
    }
}
