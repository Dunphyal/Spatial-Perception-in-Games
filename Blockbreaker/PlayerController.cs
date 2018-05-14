using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    void Update()
    {

        
        float moveVertical = Input.GetAxis("Vertical");
        float moveJump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(0.0f, moveJump, moveVertical);

        GetComponent<Rigidbody>().velocity = movement * speed;

    }
}
