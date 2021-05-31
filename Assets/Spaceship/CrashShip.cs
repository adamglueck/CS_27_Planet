using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashShip : MonoBehaviour
{
    public FauxGravityAttractor attractor;
    private Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
       // GetComponent<Rigidbody>().useGravity = false;
        myTransform = transform;
        //GetComponent<Rigidbody>().AddTorque(20, 1, 1);
        //create a convenient reference to transform
    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(myTransform);

    }
}
