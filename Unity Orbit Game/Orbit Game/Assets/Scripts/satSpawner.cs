using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satSpawner : MonoBehaviour
{
    public Transform parent;
    public GameObject satChild;
    float satAngle;
    Quaternion angleSat;
    public int satCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetButtonDown("SpawnSat"))
        {     
            satCount ++;
            satAngle = 360 / satCount;
            angleSat = new Quaternion(0, 0, satAngle, 0);
            Quaternion actAngle = parent.rotation * angleSat; 
            print(satAngle);
            GameObject sat;
            sat = Instantiate(satChild, parent.position, actAngle, parent);
            //sat.satNumb = 1;
            //Instantiate(satChild, parent, false);
        }

    }
}
