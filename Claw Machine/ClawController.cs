using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//public class Boundary
//{
//    public float xMin, xMax, zMin, zMax, yMin, yMax;

//}

public class ClawController : MonoBehaviour {

    public float speed;
    //public Boundary boundary;
    


    void Update()
    {
      
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveJump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(moveHorizontal, moveJump, moveVertical);

        GetComponent<Rigidbody>().velocity = movement * speed;
        //GetComponent<Rigidbody>().AddForce(movement * speed);
        //GetComponent<Rigidbody>().position = new Vector3
        //   (
        //    Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
        //    Mathf.Clamp(GetComponent<Rigidbody>().position.y, boundary.yMin, boundary.yMax),
        //    Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax) 
        //   );

    }
}
