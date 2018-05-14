using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpLifeSpan : MonoBehaviour {

    private float time;
    public int lifespan;

	// Use this for initialization
	void Start () {
        time = 0;
	}

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time);
        if (time > lifespan)
        {
            Destroy(gameObject);
        }
    }
}
