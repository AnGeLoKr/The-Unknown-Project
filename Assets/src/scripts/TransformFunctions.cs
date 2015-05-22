using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    
    
    void Update ()
    { 
        if(Input.GetAxis("Mouse Y") <= 0)
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if(Input.GetAxis("Mouse X") >= 0)
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}

