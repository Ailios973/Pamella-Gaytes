using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScieUpDown : MonoBehaviour {
    private bool down = true;
    private Vector3 targetup = new Vector3(0, 14, 0);
    private Vector3 targetdown = new Vector3(0, 9, 0);

    void Update ()
    {
        transform.Rotate(0, 0, Time.deltaTime * 100000);
        if (down)
        {
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
            if(targetup.y - transform.position.y <= 0)
                down = false;
        }
        if (!down)
        {
            transform.Translate(Vector3.down * Time.deltaTime, Space.World);
            if (targetdown.y - transform.position.y >= 0)
            {
                down = true;
            }
        }
    }
}
