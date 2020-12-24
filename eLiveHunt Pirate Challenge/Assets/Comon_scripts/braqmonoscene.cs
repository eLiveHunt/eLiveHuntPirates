using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class braqmonoscene : MonoBehaviour
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
    void Start()
    {
        for (i = 1; i < 7; i++)
        {
            Enigmes[i].gameObject.SetActive(false);
        }

        ARcam.gameObject.SetActive(false);

        for (i = 0; i < 3; i++)
        {
            inter[i].gameObject.SetActive(false);
        }

        for (i = 0; i < 5; i++)
        {
            target[i].gameObject.SetActive(false);
        }

        CodePanel.gameObject.SetActive(false);
        DirecPanel.gameObject.SetActive(false);
        Direc_Open.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to validate each step with a passworl
    public void Val_Cod()
    {
        code = Pass.text;
        if(code != null)
        {
            if (code == "24062010")
            {
                Enigmes[0].gameObject.SetActive(false);
                Delete_Field();
                CodePanel.gameObject.SetActive(false);
                inter[0].gameObject.SetActive(true);
            }

            else if (code == "1525")
            {
                Enigmes[2].gameObject.SetActive(false);
                CodePanel.gameObject.SetActive(false);
                Delete_Field();
                target[1].gameObject.SetActive(false);
                ARcam.gameObject.SetActive(true);
                Enigmes[3].gameObject.SetActive(true);
                Code_Open.gameObject.SetActive(true);
            }

            else if (code == "581")
            {
                Enigmes[3].gameObject.SetActive(false);
                Delete_Field();
                CodePanel.gameObject.SetActive(false);
                target[2].gameObject.SetActive(false);
                inter[1].gameObject.SetActive(true);
            }

            else if (code == "13052016")
            {
                Enigmes[5].gameObject.SetActive(false);
                Delete_Field();
                CodePanel.gameObject.SetActive(false);
                target[4].gameObject.SetActive(false);
                Enigmes[6].gameObject.SetActive(true);
                Code_Open.gameObject.SetActive(true);
            }

            else if (code == "DIAMOND")
            {
                Enigmes[6].gameObject.SetActive(false);
                Delete_Field();
                CodePanel.gameObject.SetActive(false);
                inter[2].gameObject.SetActive(true);
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
        Pass.text = null;
        code = null;
        wordindex = 0;
    }

    //method to validate direction panel code
    public void Val_Dir()
    {
        if (code == "E S S E ")
        {
            Enigmes[1].gameObject.SetActive(false);
            DirecPanel.gameObject.SetActive(false);
            Delete_Field();
            target[0].gameObject.SetActive(false);
            ARcam.gameObject.SetActive(true);
            Enigmes[2].gameObject.SetActive(true);
            Code_Open.gameObject.SetActive(true);
        }

        else if (code == "E N E E N S ")
        {
            Enigmes[4].gameObject.SetActive(false);
            DirecPanel.gameObject.SetActive(false);
            Delete_Field();
            target[3].gameObject.SetActive(false);
            ARcam.gameObject.SetActive(true);
            Enigmes[5].gameObject.SetActive(true);
            Code_Open.gameObject.SetActive(true);
        }

        else
        {
            code = null;
            wordindex = 0;
            Aff_alpha.text = "Wrong Password";
        }
    }

    //method to switch from inter 1 
    public void inter1()
    {
        inter[0].gameObject.SetActive(false);
        Maincam.gameObject.SetActive(false);
        ARcam.gameObject.SetActive(true);
        Enigmes[1].gameObject.SetActive(true);
        Direc_Open.gameObject.SetActive(true);
    }

    //method to switch from inter 2
    public void inter2()
    {
        inter[1].gameObject.SetActive(false);
        Maincam.gameObject.SetActive(false);
        ARcam.gameObject.SetActive(true);
        Enigmes[4].gameObject.SetActive(true);
        Direc_Open.gameObject.SetActive(true);
    }

    public void keeptarg(GameObject targettokeep)
    {
        targettokeep.gameObject.SetActive(true);
        ARcam.gameObject.SetActive(false);
        Maincam.gameObject.SetActive(true);
    }

    //method to close direction panel
    public void Closedir()
    {
        DirecPanel.gameObject.SetActive(false);
        Direc_Open.gameObject.SetActive(true);
    }

    //method to close code panel
    public void Closecod()
    {
        CodePanel.gameObject.SetActive(false);
        Code_Open.gameObject.SetActive(true);
    }

    //method to open direction panel
    public void Opendir()
    {
        DirecPanel.gameObject.SetActive(true);
        Direc_Open.gameObject.SetActive(false);
    }

    //method to open code panel
    public void Opendcod()
    {
        CodePanel.gameObject.SetActive(true);
        Code_Open.gameObject.SetActive(false);
    }
}
