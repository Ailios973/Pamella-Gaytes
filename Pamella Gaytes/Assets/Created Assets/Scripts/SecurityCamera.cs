using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed;
    private void LateUpdate()
    {
        transform.LookAt(target);
    }

}
