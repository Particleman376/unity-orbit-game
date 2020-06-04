using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satSpawner : MonoBehaviour
{
    public Transform parent;
    public GameObject satChild;
    float satAngle = 0.000f;
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
            Quaternion offSet = Quaternion.Euler(0, 0, satAngle * (satCount - 1));
            //print(offSet.eulerAngles);
            Quaternion actAngle = Quaternion.Euler(parent.rotation.eulerAngles + offSet.eulerAngles); 
            GameObject sat;
            sat = Instantiate(satChild, parent.position, actAngle, parent);
        }

    }
}
