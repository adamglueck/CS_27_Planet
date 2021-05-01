using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{
    public float gravity = -10;
    public void Attract(Transform body)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;///direction the body should be facing
        Vector3 bodyUp = body.up;//direction the body is currently facing
        body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);
        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation; //Gives us the rotational difference + initial rotation
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50 * Time.deltaTime);




    }

}
