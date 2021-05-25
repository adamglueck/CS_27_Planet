using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControl : MonoBehaviour
{
    public Transform target;
    public Transform self;
    public Transform spaceship;
    public Transform head;
    public float damping = 10;
    private float targetpitch;
    private float targetroll;
  
    // Start is called before the first frame update
    void Start()
    {
        self.LookAt(target);
        targetroll = head.position.x-self.position.x;
        targetpitch = head.position.z - self.position.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        self.LookAt(target);
        targetroll = head.position.x - self.position.x;
        targetpitch = head.position.z - self.position.z;
        //targetpitch = (self.eulerAngles.x);
        Debug.Log(targetpitch);
        //targetroll = (self.eulerAngles.y);
        
        spaceship.rotation = Quaternion.Slerp(spaceship.rotation, spaceship.rotation* Quaternion.Euler(new Vector3(-3*targetpitch, 0,3*targetroll)), Time.deltaTime * damping);
        spaceship.position +=(spaceship.rotation*(new Vector3( 0,0, 30 * Time.deltaTime)));
    }
}