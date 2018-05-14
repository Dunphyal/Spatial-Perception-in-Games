using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (LevelSelectScript.CastShadows == false) {
            Light Directional = GetComponent<Light>();
             Directional.shadows = LightShadows.None;
        }
	}

}
