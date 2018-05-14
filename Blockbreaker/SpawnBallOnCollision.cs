using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallOnCollision : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        GameControllerScript.instance.SpawnExtraBall();
        Destroy(gameObject);
    }
}
