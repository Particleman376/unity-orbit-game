using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Vector3 target;
    Vector3 diff;

    // Update is called once per frame
    void Update()
    {
        //code below is for pointing at mouse but really convoluted       
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        diff = target - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
}
