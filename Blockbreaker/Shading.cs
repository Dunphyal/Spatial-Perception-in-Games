using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shading : MonoBehaviour {

    public Material Mat1;
    public Material Mat2;
    public Material Mat3;
    public Material Mat4;
    public Material Mat5;

    // Use this for initialization
    void Start()
    {
        if (LevelSelectScript.Shading == true)
        {
            Debug.Log("Don't Change");
            //GetComponent<Renderer>().material.shader = Shader.Find("Unlit/Color");
            Mat1.shader = Shader.Find("Standard");
            Mat2.shader = Shader.Find("Standard");
            Mat3.shader = Shader.Find("Standard");
            Mat4.shader = Shader.Find("Standard");
            Mat5.shader = Shader.Find("Standard");
        }
        else if (LevelSelectScript.Shading == false)
        {
            Debug.Log("ChangeMaterials");
            Mat1.shader = Shader.Find("Unlit/Color");
            Mat2.shader = Shader.Find("Unlit/Color");
            Mat3.shader = Shader.Find("Unlit/Texture");
            Mat4.shader = Shader.Find("Unlit/Color");
            Mat5.shader = Shader.Find("Unlit/Color");
        }
    }
}
