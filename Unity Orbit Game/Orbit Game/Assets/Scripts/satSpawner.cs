using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satSpawner : MonoBehaviour
{
    public Transform parent;
    public GameObject satChild;
    float satAngle;
 
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
            
            print(satAngle);
            GameObject sat;
            sat = Instantiate(satChild, parent.position, Quaternion.AngleAxis(satAngle, parent.forward), parent);
            //sat.satNumb = 1;
            //Instantiate(satChild, parent, false);
        }

    }
}
