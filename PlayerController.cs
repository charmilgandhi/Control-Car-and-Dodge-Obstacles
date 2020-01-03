using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Move the vechicle forward
        //transform.Translate(0,0,1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); //Delta Time represents time interval (1 sec).
        //Here speed becomes 10m/s
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
