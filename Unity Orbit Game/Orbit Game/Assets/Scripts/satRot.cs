using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satRot : MonoBehaviour
{
    int offSet = 0;
    int mySet = 0;
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
        mySet = cloneScript.set;
        switch(cloneScript.set)
        {
            case 1:
                arrNumb = cloneScript.satCount1 - 1;
                break;
            case 2:
                arrNumb = cloneScript.satCount2 - 1;
                break;
            case 3:
                arrNumb = cloneScript.satCount3 - 1;
                break;
        }
        
        //print(arrNumb);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cloneScript = GameObject.Find("Player").GetComponent<satSpawner>();
        switch(cloneScript.set)
        {
            case 1:
                satNumb = cloneScript.satCount1;
                offSet = 0;
                break;
            case 2:
                satNumb = cloneScript.satCount2;
                offSet = 15;
                break;
            case 3:
                satNumb = cloneScript.satCount3;
                offSet = 30;
                break; 
        }
        steps = 360/satNumb;
        goalRot = Quaternion.Euler(0, 0, steps * arrNumb + offSet);

        if(Input.GetButtonDown("SpawnSat") & mySet == cloneScript.set)
        {
            if(arrNumb == (satsDown - 1))
            {
                print(goalRot.eulerAngles - transform.eulerAngles);
            } 
        transform.Rotate(goalRot.eulerAngles - transform.eulerAngles);   
        }

        if(mySet == 1)
        {
            transform.Rotate(0, 0, Time.deltaTime * 350);
        }
        else if(mySet == 2)
        {
            transform.Rotate(0, 0, Time.deltaTime * -1);
        }
        else if(mySet == 3)
        {
            transform.Rotate(0, 0,Time.deltaTime * -100);
        }

        
            

    }
}
