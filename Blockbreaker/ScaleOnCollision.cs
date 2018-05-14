using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOnCollision : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameControllerScript.instance.ScalePlayer();
        
    }
}
