using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
    
        if (LevelSelection.Shadows == false || LevelSelection.DireectionalFlag == false)
        {

            Light Directional = GetComponent<Light>();
            Directional.shadows = LightShadows.None;
            
        }
	}
	
}
