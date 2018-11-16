using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController cC;
    public float speed = 5;
    public float turnSpeed = 2;
    // Use this for initialization
    void Start()
    {
        cC = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertInput = Input.GetAxis("Vertical");
        float horizInput = Input.GetAxis("Horizontal");

        cC.SimpleMove(transform.forward * vertInput*speed);
        
        transform.Rotate(Vector3.up*horizInput*turnSpeed);
    }
}
