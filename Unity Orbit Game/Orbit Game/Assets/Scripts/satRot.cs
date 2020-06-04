﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satRot : MonoBehaviour
{
    public int arrNumb = 0;
    public int satNumb = 0;
    int satsDown = 0;
    public float steps = 0.000f;
    Quaternion goalRot;
    bool polSwitch = false;

    satSpawner cloneScript;
    
    // Start is called before the first frame update
    void Awake()
    {
        cloneScript = GameObject.Find("Player").GetComponent<satSpawner>();
        arrNumb = cloneScript.satCount - 1;
        //print(arrNumb);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cloneScript = GameObject.Find("Player").GetComponent<satSpawner>();
        satNumb = cloneScript.satCount;
        steps = 360/satNumb;
        goalRot = Quaternion.Euler(0, 0, steps * arrNumb); //something is wrong here I think
        


        if(Input.GetButtonDown("SpawnSat"))
        {
            if(arrNumb == (satsDown - 1))
            {
                print(goalRot.eulerAngles - transform.eulerAngles);
            } 
            transform.Rotate(goalRot.eulerAngles - transform.eulerAngles);   
        }
            

    }
}
