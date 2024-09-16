using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 5;
    void Update()
    {
        //Move the vehichle foward
        transform.Translate(Vector3.forward * Time.deltaTime * 5);
    }
}
