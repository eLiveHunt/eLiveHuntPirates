using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test_split_dir_panel : MonoBehaviour
{
    int wordindex = 0;
    public Text Aff_alpha = null;
    public GameObject Enigme3, Enigme4, target3, ARcam, Maincam, Direc_Open, Code_Open, CodePanel;
    public string code = null;
    public InputField dir_to_hide;

    private void Start()
    {
        dir_to_hide.gameObject.SetActive(false);
    }

    //method for direction button code entering
    public void Alpha_Function(string alpha)
    {
        if (Aff_alpha.text == "Wrong Password")
        {
            Aff_alpha.text = null;
        }

        wordindex++;
        code = code + alpha;
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
        Debug.Log(code);
        if (code == "WESN")
        {
            Debug.Log("correct");
            Enigme3.gameObject.SetActive(false);
            CodePanel.gameObject.SetActive(false);
            target3.gameObject.SetActive(false);
            Enigme4.gameObject.SetActive(true);
            Code_Open.gameObject.SetActive(true);
            
        }

        else if (code != "WESN")
        {
            Debug.Log("wrong");
            code = null;
            wordindex = 0;
            Aff_alpha.text = "Wrong Password";
        }
    }


}
