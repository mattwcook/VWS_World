using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotion : MonoBehaviour
{
    Rigidbody rb;
    float rotationSpeed = 90;
    float movementSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.eulerAngles += new Vector3(0, Input.GetAxis("Horizontal"), 0) * rotationSpeed * Time.deltaTime; 
            
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            rb.velocity = transform.forward * movementSpeed * Input.GetAxis("Vertical");
        }
    }
}
