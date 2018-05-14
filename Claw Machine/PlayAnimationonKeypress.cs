using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationonKeypress : MonoBehaviour {

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("Closing");

        }

        if (Input.GetKeyDown("2"))
        {
            anim.Play("Opening");

        }
    }
}
