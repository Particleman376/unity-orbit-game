using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satSpawner : MonoBehaviour
{
    public Transform parent;
    public Transform satChild;
    public Vector3 orbitDistance = new Vector3(0, 2, 0);
    Quaternion rotOffset = new Quaternion(0, 0, 90, 0);
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
            Instantiate(satChild, GameObject.Find("RotBase").transform.position - orbitDistance, Quaternion.identity, parent);
        }

    }
}
