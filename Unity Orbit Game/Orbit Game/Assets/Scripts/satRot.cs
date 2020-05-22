using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satRot : MonoBehaviour
{
    int arrNumb = 0;
    public int satNumb = 0;
    float steps = 0.0f;

    satSpawner cloneScript;
    
    // Start is called before the first frame update
    void Awake()
    {
        cloneScript = GameObject.Find("Player").GetComponent<satSpawner>();
        arrNumb = cloneScript.satCount;
        print(arrNumb);
    }

    // Update is called once per frame
    void Update()
    {
        cloneScript = GameObject.Find("Player").GetComponent<satSpawner>();
        satNumb = cloneScript.satCount;
        steps = satNumb/360;
          if(Input.GetAxis("SpawnSat") == 1.0f)
            print(arrNumb);
            transform.rotation = Quaternion.Euler(0, 0, steps * arrNumb);
    }
}
