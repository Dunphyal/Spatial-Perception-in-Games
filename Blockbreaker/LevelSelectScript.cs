using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelSelectScript : MonoBehaviour {

    public Toggle ShadowsToggle;
    public Toggle ShadingToggle;
    public Toggle Perspective;
    public Toggle DepthofField;
    public Text FoVChoice;
    public static bool CastShadows = true;
    public static bool Shading = true;

    //public void CheckLevelConfirm()
    //{
    //    if (Shadows.isOn == true && Perspective.isOn == true && DepthofField.isOn == true)
    //    {
    //        SceneManager.LoadScene("BlockBreaker");
    //    }

    //    if (Shadows.isOn == true && Perspective.isOn == true && DepthofField.isOn == false)
    //    {
    //        SceneManager.LoadScene("BlockBreaker_NoDOF");
    //    }

    //    if (Shadows.isOn == true && Perspective.isOn == false && DepthofField.isOn == true)
    //    {
    //        SceneManager.LoadScene("BlockBreaker_Ortho");
    //    }

    //    if (Shadows.isOn == true && Perspective.isOn == false && DepthofField.isOn == false)
    //    {
    //        SceneManager.LoadScene("BlockBreaker_NoDofOrtho");
    //    }

    //    if (Shadows.isOn == false && Perspective.isOn == true && DepthofField.isOn == true)
    //    {
    //        SceneManager.LoadScene("BlockBreaker_NoShadows");
    //    }

    //    if (Shadows.isOn == false && Perspective.isOn == true && DepthofField.isOn == false)
    //    {
    //        SceneManager.LoadScene("BlockBreaker_NoDofShadows");
    //    }

    //    if (Shadows.isOn == false && Perspective.isOn == false && DepthofField.isOn == true)
    //    {
    //        SceneManager.LoadScene("BlockBreaker_OnlyDof");
    //    }

    //    if (Shadows.isOn == false && Perspective.isOn == false && DepthofField.isOn == false)
    //    {
    //        SceneManager.LoadScene("BlockBreaker_AllOff");
    //    }
    //}

    public void LoadLevel()
    {
        if (ShadowsToggle.isOn == false)
        {
            CastShadows = false;
        }
        else
        {
            CastShadows = true;
        }

        if (ShadingToggle.isOn == true)
        {
            Shading = true;
        }

        else if (ShadingToggle.isOn == false)
        {
            Shading = false;
        }

        if (Perspective.isOn == true)
        {
            if (FoVChoice.text == "FOV 60")
            {
                if (DepthofField.isOn == true)
                {
                    SceneManager.LoadScene("BlockBreaker");
                }
                else
                {
                    SceneManager.LoadScene("BlockBreaker_NoDOF");
                }
            }

            else if (FoVChoice.text == "FOV 90")
            {
                if (DepthofField.isOn == true)
                {
                    SceneManager.LoadScene("BlockBreaker_FOV90");
                }
                else
                {
                    SceneManager.LoadScene("BlockBreaker_FOV90_NoDoF");
                }
            }

            else if (FoVChoice.text == "FOV 120")
            {
                if (DepthofField.isOn == true)
                {
                    SceneManager.LoadScene("BlockBreaker_FOV120");
                }
                else
                {
                    SceneManager.LoadScene("BlockBreaker_FOV120_NoDoF");
                }
            }

            else
            {
                if (DepthofField.isOn == true)
                {
                    SceneManager.LoadScene("BlockBreaker_FOV30");
                }
                else
                {
                    SceneManager.LoadScene("BlockBreaker_FOV30_NoDoF");
                }

            }

        }

        else if (Perspective.isOn == false)
        {
            if (DepthofField.isOn == true)
            {
                SceneManager.LoadScene("BlockBreaker_Ortho");
            }
            else
            {
                SceneManager.LoadScene("BlockBreaker_Ortho_NoDOF");
            }

        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
