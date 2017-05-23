using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScie : MonoBehaviour {
    
    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * 100000);
    }
}
