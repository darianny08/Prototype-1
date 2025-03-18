using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCars : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the car foward based on verticl input
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
    
    }
}
