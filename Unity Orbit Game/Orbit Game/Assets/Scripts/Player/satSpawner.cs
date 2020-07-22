using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satSpawner : MonoBehaviour
{
    public int set = 0;
    public Transform parent;
    public GameObject satChild1;
    public GameObject satChild2;
    public GameObject satChild3;
    double satAngle = 0.000f;
    public int satCount1 = 0;
    public int satCount2 = 0;
    public int satCount3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetButtonDown("SpawnSat"))
        {     
            if(satCount1 < 2)
            {
                set = 1;
                satCount1 ++;
                satAngle = 360 / satCount1;
                Quaternion offSet = Quaternion.Euler(0, 0, (float)(satAngle * (satCount1 - 1)));
                //print(offSet.eulerAngles);
                Quaternion actAngle = Quaternion.Euler(parent.rotation.eulerAngles + offSet.eulerAngles); 
                GameObject sat;
                sat = Instantiate(satChild1, parent.position, actAngle, parent);
            }
            else if(satCount2 < 8)
            {
                set = 2;
                satCount2 ++;
                satAngle = 360 / satCount2;
                Quaternion offSet = Quaternion.Euler(0, 0, (float)(satAngle * (satCount2 - 1)));
                //print(offSet.eulerAngles);
                Quaternion actAngle = Quaternion.Euler(parent.rotation.eulerAngles + offSet.eulerAngles); 
                GameObject sat;
                sat = Instantiate(satChild2, parent.position, actAngle, parent);
            }
            else if(satCount3 < 18)
            { 
                set = 3;
                satCount3 ++;
                satAngle = 360 / satCount3;
                Quaternion offSet = Quaternion.Euler(0, 0, (float)(satAngle * (satCount3 - 1)));
                //print(offSet.eulerAngles);
                Quaternion actAngle = Quaternion.Euler(parent.rotation.eulerAngles + offSet.eulerAngles); 
                GameObject sat;
                sat = Instantiate(satChild3, parent.position, actAngle, parent);
            }

        }

    }
}
