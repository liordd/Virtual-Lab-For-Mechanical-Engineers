using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour

{
    public Rigidbody rb;
    public float speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        Freeze();
    }


    void FixedUpdate()
    {
     
    }


    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed*Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
    }

    void Freeze()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
