using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;
    private bool BallInPlay = false;
    

    void Start()
    {       
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        if(Input.anyKey && BallInPlay == false)
        {
            rb.AddForce(Random.Range(-9.0f, -10.0f) * thrust, Random.Range(-3.0f, 3.0f) * thrust, Random.Range(-3.0f, 3.0f) * thrust);
            BallInPlay = true;
        }
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
