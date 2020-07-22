using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int rotSpeed = 10;
    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(0, 0, 30 * Time.deltaTime * rotSpeed);
    }
}
