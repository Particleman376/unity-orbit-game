using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupScript : MonoBehaviour
{
    public CircleCollider2D targetCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        print("Touching");
        
        
    }
}
