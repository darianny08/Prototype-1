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
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float fowardInput;
    void Update()
    {
       horizontalInput = Input.GetAxis ("Horizontal");
       fowardInput = Input.GetAxis ("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        transform.Rotate(Vector3.up,turnSpeed * Time.deltaTime * horizontalInput);
    }
}
