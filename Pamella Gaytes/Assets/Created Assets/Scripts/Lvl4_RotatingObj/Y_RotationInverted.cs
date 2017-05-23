using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_RotationInverted : MonoBehaviour {
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * -50, 0);
    }
}
