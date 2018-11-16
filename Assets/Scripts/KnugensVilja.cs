using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnugensVilja : MonoBehaviour
{
    public float troIKnugen;
    LineRenderer lR;
    float beamPushForce;

    // Use this for initialization
    void Start()
    {
        lR = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lR.enabled = false;
        if (Input.GetKey(KeyCode.Space))
        {
            lR.enabled = true;
            lR.SetPosition(0, transform.position);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                lR.SetPosition(1, hit.point);
                hit.collider.GetComponent<Rigidbody>().AddForceAtPosition(transform.forward * troIKnugen * Time.deltaTime, hit.point);
            }
            else
            {
                lR.SetPosition(1, transform.forward * 1000);
            }
        }
    }
}
