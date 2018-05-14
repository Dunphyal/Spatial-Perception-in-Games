using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawSpotLightSwtich : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (LevelSelection.Shadows == false || LevelSelection.SpotlightFlag == false)
        {

            Light SpotLight = GetComponent<Light>();
            SpotLight.shadows = LightShadows.None;

        }


    }

}