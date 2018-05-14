using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitch : MonoBehaviour {
	
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = true;

    }
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("1"))
        {
            GetComponent<Rigidbody>().useGravity = false;
        }

        if (Input.GetKeyDown("2"))
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
