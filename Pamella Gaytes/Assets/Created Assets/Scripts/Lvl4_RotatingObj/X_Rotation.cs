using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Rotation : MonoBehaviour {
    void Update()
    {
        transform.Rotate(Time.deltaTime * 50, 0, 0);
    }
}
