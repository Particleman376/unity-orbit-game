﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement : MonoBehaviour
{
    int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed  * Time.deltaTime,Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, Space.World);
    }
}
