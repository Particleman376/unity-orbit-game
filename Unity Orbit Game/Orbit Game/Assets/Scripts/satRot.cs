using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satRot : MonoBehaviour
{
    int arrNumb = 0;
    public int satNumb = 0;
    int satsDown = 0;
    float steps = 0.0f;
    Quaternion goalRot;

    satSpawner cloneScript;
    
    // Start is called before the first frame update
    void Awake()
    {
        cloneScript = GameObject.Find("Player").GetComponent<satSpawner>();
        arrNumb = cloneScript.satCount;
        //print(arrNumb);
    }

    // Update is called once per frame
    void Update()
    {
        
        cloneScript = GameObject.Find("Player").GetComponent<satSpawner>();
        satNumb = cloneScript.satCount;
        steps = satNumb/360;
        goalRot = Quaternion.Euler(0, 0, steps * arrNumb); //something is wrong here I think
        

        if(Input.GetButtonDown("SpawnSat"))
        {
            satsDown ++;
            transform.Rotate(goalRot.eulerAngles);
        }
            

    }
}
