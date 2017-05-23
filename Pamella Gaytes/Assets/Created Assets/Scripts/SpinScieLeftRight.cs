using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScieLeftRight : MonoBehaviour {
    private bool left = true;
    private Vector3 targetleft = new Vector3(157, 0, 0);
    private Vector3 targetright = new Vector3(176, 0, 0);

	void Update ()
    {
        transform.Rotate(0, 0, Time.deltaTime * 100000);
        if (left)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 4, Space.World);
            if (targetright.x - transform.position.x <= 0)
                left = false;
        }
        if (!left)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 4, Space.World);
            if (targetleft.x - transform.position.x >= 0)
                left = true;
        }

    }
}
