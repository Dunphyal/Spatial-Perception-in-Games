using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestoryOnKeypress : MonoBehaviour {

    public Text SetupText;

    private void Start()
    {
        SetupText.text = "Press Any Key to Start";
    }

    // Update is called once per frame
    void Update () {
		if (Input.anyKey)
        {
            Destroy(SetupText);
        }
	}
}
