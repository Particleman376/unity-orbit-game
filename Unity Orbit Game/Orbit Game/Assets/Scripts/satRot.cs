using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satRot : MonoBehaviour
{
    GameObject[] satellites;
    int arrNumb = 0;
    public int satNumb = 0;
    // Start is called before the first frame update
    void Awake()
    {
        satellites = GameObject.FindGameObjectsWithTag("Electron");
    }

    // Update is called once per frame
    void Update()
    {
       foreach(GameObject satellite in satellites)
       {
           satNumb++;
           print(satNumb);
       }
    }
}
