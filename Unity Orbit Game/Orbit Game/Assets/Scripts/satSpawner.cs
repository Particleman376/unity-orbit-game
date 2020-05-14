using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satSpawner : MonoBehaviour
{
    public Transform parent;
    public Transform satChild;
    float satAngle;
 
    public int satCount = 0;
    public Quaternion rotationOffset = new Quaternion(0, 0, 0, 0);
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
            rotationOffset = new Quaternion(0, 0, satAngle, 0);
            print(rotationOffset);
            Instantiate(satChild,parent.position, parent.rotation * rotationOffset, parent);
            //Instantiate(satChild, parent, false);
        }

    }
}
