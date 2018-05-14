using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelSelection : MonoBehaviour {
    public static bool Shadows = true;
    public static bool SpotlightFlag = true;
    public static bool DireectionalFlag = true;
    public static bool Persp = true;
    public static bool UniformSize = true;
    public static int PrizeNum;
    public static int UserTimeLimit;
    public static bool Shading = true;
    public Toggle ShadowToggle;
    public Toggle ShadingToggle;
    public Toggle PerspectiveToggle;
    public Toggle UniformToggle;
    public InputField ObjectNum;
    public InputField TimeLimitValue;
    public Text SelectedFOV;
    public Text LightSourceType;


    public void CheckGameSettings()
    {
        if (ShadowToggle.isOn == false)
        {
            Shadows = false;
        }
        else 
        {
            Shadows = true;
            if(LightSourceType.text == "Only Directional")
            {
                DireectionalFlag = true;
                SpotlightFlag = false;
            }
            else if (LightSourceType.text == "Only Spotlight")
            {
                SpotlightFlag = true;
                DireectionalFlag = false;
            }
            else
            {
                SpotlightFlag = true;
                DireectionalFlag = true;
            }
        }

        if (ShadingToggle.isOn)
        {
            Shading = true;

        }
        else if(ShadingToggle.isOn == false)
        {
            Shading = false;
        }

        if (UniformToggle.isOn == false)
        {
            UniformSize = false;
        }

        else
        {
            UniformSize = true;
        }

        PrizeNum = int.Parse(ObjectNum.text);
        UserTimeLimit = int.Parse(TimeLimitValue.text);
        Debug.Log("PrizeNum");
        if (PerspectiveToggle.isOn == false)
        {
            Persp = false;
            SceneManager.LoadScene("OrthoClawMachine");
        }
        else
        {

            if (SelectedFOV.text == "FOV 60")
            {
                SceneManager.LoadScene("ClawMachine");
            }
            else if (SelectedFOV.text == "FOV 90")
            {
                SceneManager.LoadScene("ClawMachine_FOV_90");
            }
            else if (SelectedFOV.text == "FOV 120")
            {
                SceneManager.LoadScene("ClawMachine_FOV_120");
            }
            else
            {
                SceneManager.LoadScene("ClawMachine_FOV_30");
            }
        }
    }

    //public void PlayOriginal()
    //{
    //    SceneManager.LoadScene("ClawMachine");

    //}

    //public void PlayNoShadows()
    //{
    //    SceneManager.LoadScene("ClawMachine_NoShadows");

    //}

    //public void PlayOrtho()
    //{
    //    SceneManager.LoadScene("ClawMachine_Ortho");

    //}

    //public void PlayRandScale()
    //{
    //    SceneManager.LoadScene("ClawMachine_RandomScale");

    //}

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");

    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
