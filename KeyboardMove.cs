using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMove : MonoBehaviour
{
    public float MoveSpeed = 1.0f;
    public bool temp = false;
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed * 200);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed * 200);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Transform>().Translate(Vector3.up * Time.deltaTime * MoveSpeed * 200);
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 50);
        }
        if (Input.GetKey(KeyCode.W))
        {
            temp = true;
        }
            if (temp==true)
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed * 200);
        }
        
    }
    
}
