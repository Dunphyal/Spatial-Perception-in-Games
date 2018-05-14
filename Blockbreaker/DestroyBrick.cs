using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBrick : MonoBehaviour {

    public GameObject Shatter;
    public GameObject ShatterAlt;
    private GameObject Chosen;
    private int RandomNum;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("collision detected!");
            Destroy(gameObject);
            RandomNum = Random.Range(0, 4);
            if(RandomNum%2 == 0)
            {
                Chosen = Shatter;
                Debug.Log("Shatter");
            }
            else
            {

                Chosen = ShatterAlt;
                Debug.Log("ShatterAlt");
            }
            GameObject ShatteredBrick = Instantiate(Chosen, transform.position, Quaternion.identity);
            GameControllerScript.instance.BrickNumber();
 
        }
    }
}
