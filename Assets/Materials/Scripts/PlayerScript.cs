using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    bool moveForwardFlg;
    bool moveBackFlg;

    float moveSpeed = 10;
    float rotateSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0) * rotateSpeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0) * rotateSpeed*Time.deltaTime);
        }
        moveForwardFlg = Input.GetKey(KeyCode.UpArrow);
        moveBackFlg = Input.GetKey(KeyCode.DownArrow);
    }

    void FixedUpdate()
    {
        if(moveForwardFlg)
        {
            rb.velocity = transform.forward * moveSpeed;
        }
        else if (moveBackFlg)
        {
            rb.velocity = -transform.forward * moveSpeed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
