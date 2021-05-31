using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchships : MonoBehaviour
{
    public GameObject ship1;
    public GameObject ship2;
    public Transform viewer;
    public float distancebtwn;
    // Start is called before the first frame update
    void Start()
    {
        ship1.SetActive(true);
        ship2.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        distancebtwn = Vector3.Distance(ship1.transform.position, viewer.position);
        if (distancebtwn > 30)
        {
            Debug.Log(distancebtwn);
            ship1.SetActive(false);
            ship2.SetActive(true);
        }

    }
}
