using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadingOn : MonoBehaviour {

    public Material Metal;
    public Material WhitePlastic;
    public Material Plastic;
    public Material PickUpMat;
    public Material PickUpMat2;

    // Use this for initialization
    void Start()
    {
        if (LevelSelection.Shading == true)
        {
            Debug.Log("Don't Change");
            //GetComponent<Renderer>().material.shader = Shader.Find("Unlit/Color");
            Metal.shader = Shader.Find("Standard (Roughness setup)");
            WhitePlastic.shader = Shader.Find("Standard (Specular setup)");
            Plastic.shader = Shader.Find("Standard (Specular setup)");
            PickUpMat.shader = Shader.Find("Standard");
            PickUpMat2.shader = Shader.Find("Standard");
        }
        else if (LevelSelection.Shading == false)
        {
            Debug.Log("ChangeMaterials");
            Metal.shader = Shader.Find("Unlit/Color");
            WhitePlastic.shader = Shader.Find("Unlit/Color");
            Plastic.shader = Shader.Find("Unlit/Color");
            PickUpMat.shader = Shader.Find("Unlit/Texture");
            PickUpMat2.shader = Shader.Find("Unlit/Texture");
        }
    }
}
