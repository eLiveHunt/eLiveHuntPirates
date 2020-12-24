﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tempmonoscene : MonoBehaviour
{
    private int i;
    public GameObject[] Enigmes;
    public GameObject[] inter;
    public GameObject[] target;
    public GameObject ARcam;
    public GameObject Maincam;
    public InputField Pass;
    public string code = null;
    public Text txt;
    public GameObject CodePanel;
    public GameObject Open_boutton;

    // Start is called before the first frame update
    void Start()
    {
        for (i = 1; i < 7; i++)
        {
            Enigmes[i].gameObject.SetActive(false);
        }

        ARcam.gameObject.SetActive(false);

        for (i = 0; i < 4; i++)
        {
            inter[i].gameObject.SetActive(false);
        }

        for (i = 0; i < 4; i++)
        {
            target[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //function to validate each step with a password
    public void Enter_Push()
    {
        code = Pass.text;
        if (Pass.text != null)
        {
            if (code == "WATER" || code == "water")
            {
                Enigmes[0].gameObject.SetActive(false);
                Enigmes[1].gameObject.SetActive(true);
                CodePanel.gameObject.SetActive(false);
                Pass.text = null;
                
            }

            else if (code == "CRYPTEX" || code == "cryptex")
            {
                Enigmes[1].gameObject.SetActive(false);
                inter[0].gameObject.SetActive(true);
                CodePanel.gameObject.SetActive(false);
                Pass.text = null;
            }

            else if (code == "6784")
            {
                Enigmes[2].gameObject.SetActive(false);
                target[0].gameObject.SetActive(false);
                Enigmes[3].gameObject.SetActive(true);
                CodePanel.gameObject.SetActive(false);
                Pass.text = null;
            }

            else if (code == "VMS" || code == "vms")
            {
                Enigmes[3].gameObject.SetActive(false);
                target[1].gameObject.SetActive(false);
                ARcam.gameObject.SetActive(false);
                Maincam.gameObject.SetActive(true);
                inter[1].gameObject.SetActive(true);
                CodePanel.gameObject.SetActive(false);
                Pass.text = null;
            }

            else if (code == "2654")
            {
                Enigmes[4].gameObject.SetActive(false);
                target[2].gameObject.SetActive(false);
                Maincam.gameObject.SetActive(true);
                ARcam.gameObject.SetActive(false);
                Enigmes[5].gameObject.SetActive(true);
                CodePanel.gameObject.SetActive(false);
                Pass.text = null;
            }

            else if (code == "750")
            {
                Enigmes[5].gameObject.SetActive(false);
                inter[2].gameObject.SetActive(true);
                CodePanel.gameObject.SetActive(false);
                Pass.text = null;
            }

            else if (code == "5632")
            {
                Enigmes[6].gameObject.SetActive(false);
                target[3].gameObject.SetActive(false);
                ARcam.gameObject.SetActive(false);
                Maincam.gameObject.SetActive(true);
                inter[3].gameObject.SetActive(true);
                CodePanel.gameObject.SetActive(false);
                Pass.text = null;
            }
        }
    }

    //method to switch from inter 1 to next step
    public void inter1()
    {
        inter[0].gameObject.SetActive(false);
        Maincam.gameObject.SetActive(false);
        ARcam.gameObject.SetActive(true);
        Enigmes[1].gameObject.SetActive(true);
        Open_boutton.gameObject.SetActive(true);
    }

    //methos to switch from inter 2 to next step
    public void inter2()
    {
        inter[1].gameObject.SetActive(false);
        Maincam.gameObject.SetActive(false);
        ARcam.gameObject.SetActive(true);
        Enigmes[3].gameObject.SetActive(true);
        Open_boutton.gameObject.SetActive(true);
    }

    //method to sitch from inter 3 to next step
    public void inter3()
    {
        inter[2].gameObject.SetActive(false);
        Maincam.gameObject.SetActive(false);
        ARcam.gameObject.SetActive(true);
        Enigmes[6].gameObject.SetActive(true);
        Open_boutton.gameObject.SetActive(true);
    }

    //method to keep that AR image shown on device screen
    public void kepptarg(GameObject targtokeep)
    {
        targtokeep.gameObject.SetActive(true);
        ARcam.gameObject.SetActive(false);
        Maincam.gameObject.SetActive(true);
    }
}
