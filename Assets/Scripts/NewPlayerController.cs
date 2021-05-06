using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour
{
    public float moveSpeed = 12;
    private Vector3 moveDir;
    private float yrot = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
      //moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        moveDir = new Vector3((OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick)[0]), 0, (OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick)[1])).normalized;
        

    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir * moveSpeed * Time.deltaTime));
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight)){
            GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(0, 5, 0));
            yrot = yrot + 5;

        }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft)){
            GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(0, -5, 0));
            yrot = yrot - 5;
        }
           // if (Input.GetKeyDown(KeyCode.Space))
            //{
             //  Debug.Log("space was pressed");
             // GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(0, 5,0));
           // yrot = yrot + 15;
            //}
        }
}
