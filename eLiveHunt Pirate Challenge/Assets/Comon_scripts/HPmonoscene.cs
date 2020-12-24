using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPmonoscene : MonoBehaviour
{
    private int i;
    int wordindex = 0;
    [SerializeField] public Text Aff_alpha = null;
    public GameObject[] Enigmes;
    public GameObject[] inter;
    public GameObject[] target;
    public GameObject ARcam;
    public GameObject Maincam;
    public InputField Pass;
    public string code = null;
    public Text txt;
    public GameObject CodePanel;
    public GameObject DirecPanel;
    public GameObject Code_Open;
    public GameObject Direc_Open;

    // Start is called before the first frame update
    // Used here to only hsow the content linked to first step of the challenge
    void Start()
    {
        Maincam.gameObject.SetActive(false);

        for (i = 0; i < 5; i++)
        {
            inter[i].gameObject.SetActive(false);
        }

        for (i = 0; i < 6; i++)
        {
            target[i].gameObject.SetActive(false);
        }

        for (i = 1; i < 7; i++)
        {
            Enigmes[i].gameObject.SetActive(false);
        }

        CodePanel.gameObject.SetActive(false);
        DirecPanel.gameObject.SetActive(false);
        Direc_Open.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method to validate each step with a password
    public void Val_Cod()
    {
        code = Pass.text;
        if (Pass.text != null)
        {
            if (code == "31071980")
            {
                Enigmes[0].gameObject.SetActive(false);
                Pass.text = null;
                CodePanel.gameObject.SetActive(false);
                target[0].gameObject.SetActive(false);
                ARcam.gameObject.SetActive(false);
                inter[0].gameObject.SetActive(true);
            }

            else if (code == "HORCRUXE")
            {
                Enigmes[1].gameObject.SetActive(false);
                Pass.text = null;
                CodePanel.gameObject.SetActive(false);
                Maincam.gameObject.SetActive(false);
                ARcam.gameObject.SetActive(true);
                Enigmes[2].gameObject.SetActive(true);
                Code_Open.gameObject.SetActive(true);
            }

            else if (code == "24695")
            {
                Enigmes[2].gameObject.SetActive(false);
                Pass.text = null;
                CodePanel.gameObject.SetActive(false);
                target[1].gameObject.SetActive(false);
                Maincam.gameObject.SetActive(true);
                Enigmes[3].gameObject.SetActive(true);
                Code_Open.gameObject.SetActive(true);
            }
        }
    }

    //method for direction button code entering
    public void Alpha_Function(string alpha)
    {
        wordindex++;
        code = code + alpha + " ";
        Aff_alpha.text = code;
    }

    //method to delete field in direction code panel
    public void Delete_Field()
    {
        Aff_alpha.text = "";
        code = null;
        wordindex = 0;
    }

    //method to validate direction panel code
    public void Val_Dir()
    {
        if (code == "W E S N ")
        {
            Enigmes[2].gameObject.SetActive(false);
            DirecPanel.gameObject.SetActive(false);
            target[1].gameObject.SetActive(false);
            Enigmes[3].gameObject.SetActive(true);
            Code_Open.gameObject.SetActive(true);
        }

        else
        {
            code = null;
            wordindex = 0;
            Aff_alpha.text = "Wrong Password";
        }
    }

    //method to switch from inter 1 to next step
    public void inter1()
    {
        inter[0].gameObject.SetActive(false);
        Maincam.gameObject.SetActive(false);
        ARcam.gameObject.SetActive(true);
        Enigmes[1].gameObject.SetActive(true);
        Code_Open.gameObject.SetActive(true);
    }

    //method to switch from inter 2 to next step
    public void inter2()
    {
        inter[1].gameObject.SetActive(false);
        Maincam.gameObject.SetActive(false);
        ARcam.gameObject.SetActive(true);
        Enigmes[5].gameObject.SetActive(true);
        Code_Open.gameObject.SetActive(true);
    }

    //method to keep taht AR image shown on device screen
    public void keeptarg(GameObject targtokeep)
    {
        targtokeep.gameObject.SetActive(true);
    }

    public void Closedir()
    {
        DirecPanel.gameObject.SetActive(false);
        Direc_Open.gameObject.SetActive(true);
    }

    public void Closecod()
    {
        CodePanel.gameObject.SetActive(false);
        Code_Open.gameObject.SetActive(true);
    }

    public void Opendir()
    {
        DirecPanel.gameObject.SetActive(true);
        Direc_Open.gameObject.SetActive(false);
    }

    public void Opendcod()
    {
        CodePanel.gameObject.SetActive(true);
        Code_Open.gameObject.SetActive(false);
    }
}
