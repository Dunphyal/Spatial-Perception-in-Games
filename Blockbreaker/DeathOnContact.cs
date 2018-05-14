using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnContact : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("collision");
            Destroy(other.gameObject);
        }
    }
}
