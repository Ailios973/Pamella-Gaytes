using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed;
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y + 0.25f, transform.position.z), Time.deltaTime * lerpSpeed);
    }

}
