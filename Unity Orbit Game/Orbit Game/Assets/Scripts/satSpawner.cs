using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satSpawner : MonoBehaviour
{
    public Transform parent;
    public Transform satChild;
    public Vector3 orbitDistance = new Vector3(0, 2, 0);
    Quaternion rotOffset = new Quaternion(0, 0, 0, 0);
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
            switch(satCount)
            {
            case 1:
                rotOffset = new Quaternion(0, 0, 0, 0);
                break;
            case 2:
                rotOffset = new Quaternion(0, 0, 180, 0);
                break;
            }
            Instantiate(satChild, parent.position + orbitDistance, parent.rotation * rotOffset, parent);
            //Instantiate(satChild, parent, false);
        }

    }
}
