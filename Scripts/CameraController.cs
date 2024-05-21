using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float movspeed = 3f;
    [SerializeField] private float rotspeed = 1f;
    void Start()
    {
    }
    void Update()
    {
        Vector3 inputVector = new Vector3(0, 0 ,0);
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += transform.right;
        }
        if (Input.GetKey(KeyCode.W))
        {
            inputVector +=transform.forward ;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector -= transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector -= transform.forward;
        }
        if (Input.GetKey(KeyCode.R))
        {
            inputVector += transform.up;
        }
        if (Input.GetKey(KeyCode.F))
        {
            inputVector -= transform.up;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, rotspeed, 0); 
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0, -rotspeed, 0); 
        }
       
        inputVector = inputVector.normalized;
        Vector3 vector3 = new Vector3(inputVector.x, inputVector.y, inputVector.z);
        transform.position += vector3 * movspeed * Time.deltaTime;
       // Debug.Log(transform.position);
    }
}

