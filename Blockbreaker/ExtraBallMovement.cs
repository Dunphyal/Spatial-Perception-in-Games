using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBallMovement : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Random.Range(-9.0f, -10.0f) * thrust, Random.Range(-3.0f, 3.0f) * thrust, Random.Range(-3.0f, 3.0f) * thrust);

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "DeadZone")
        {
            
            Debug.Log("deadwall");
            Destroy(gameObject);
            GameControllerScript.instance.ActiveBallCount();
            GameControllerScript.instance.PlayerLifes();
        }
    }

}
