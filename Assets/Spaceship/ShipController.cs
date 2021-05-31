using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    private Vector3 moveDir;
    private float moveSpeed = 12;
    private Quaternion newRotation;
    // Start is called before the first frame update
    void Start()
    {
        moveDir = new Vector3(0, 0, -1);
        newRotation = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        newRotation = Quaternion.Euler(new Vector3(20*Time.fixedDeltaTime*(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick)[1]), -40 * Time.fixedDeltaTime * (OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick)[1]), (20*Time.fixedDeltaTime*OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick)[0])));
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (GetComponent<Rigidbody>().rotation*moveDir * moveSpeed * Time.deltaTime));
        GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * newRotation);
    }
}
