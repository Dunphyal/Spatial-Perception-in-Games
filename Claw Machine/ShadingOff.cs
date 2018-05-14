using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadingOff : MonoBehaviour {


    public Material Metal;
    public Material WhitePlastic;
    public Material Plastic;
    public Material PickUpMat;
    public Material PickUpMat2;

    // Use this for initialization
    void Start () {
        //GetComponent<Renderer>().material.shader = Shader.Find("Unlit/Color");
        Metal.shader = Shader.Find("Unlit/Color");
        WhitePlastic.shader = Shader.Find("Unlit/Color");
        Plastic.shader = Shader.Find("Unlit/Color");
        PickUpMat.shader = Shader.Find("Unlit/Texture");
        PickUpMat2.shader = Shader.Find("Unlit/Texture");

    }

    // Update is called once per fr
}
