using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satSpawner : MonoBehaviour
{
    public Transform parent;
    public Transform satChild;
    Vector3 offset = new Vector3(0, 2, 0);
    int satCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("SpawnSat"))
        {
        /*    satCount += 1;
            switch(satCount)
            {
                case 1:
                    offset = new Vector3(0, 2, 0);
                    break;
                case 2:
                    offset = new Vector3(0, -2, 0);
                    break;
                case 3: 
                    offset = new Vector3(2, 0, 0);
                    break;
                case 4:
                    offset = new Vector3(-2, 0, 0);
                    break;
            } */
            Instantiate(satChild, GameObject.Find("RotBase").transform.position - offset, Quaternion.identity, parent);
        }
            
    }
}
