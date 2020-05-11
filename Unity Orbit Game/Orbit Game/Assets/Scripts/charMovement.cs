using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement : MonoBehaviour
{
    float timeSinceTouch;
    int speed = 5;
    public Transform targetPos;
    Vector3 goalPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        goalPos = targetPos.position - transform.position;
        if(timeSinceTouch > 1)
        {
            transform.Translate(Time.deltaTime * goalPos, Space.World);
        }

        transform.Translate(Input.GetAxis("Horizontal") * speed  * Time.deltaTime,Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, Space.World);

    }

    void FixedUpdate()
    {
        if(Input.GetAxis("Horizontal") == 0.0 || Input.GetAxis("Vertical") == 0.0)
        {
            timeSinceTouch += Time.fixedDeltaTime;
        }
        else
        {
            timeSinceTouch = 0;
        }
    }
}
