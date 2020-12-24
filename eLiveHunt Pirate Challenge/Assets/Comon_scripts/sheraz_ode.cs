using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sheraz_ode : MonoBehaviour
{
    public InputField Pass;
    public string code = null;
    public Text txt;
    public string To_Load1;
    public string To_Load2;
    public string To_Load3;
    public string To_Load4;
    public string To_Load5;
    public string To_Load6;
    public string To_Load7;
    [SerializeField] public Text Aff_alpha = null;



    public void Enter_Push()
    {
        code = Pass.text;
        if (Pass.text != null)
        {
            if (code == "1735")
            {

                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load2);
            }
            else if (code == "PLC" || code == "plc")
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load3);
            }
            else if (code == "5384")
            {

                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load1);
            }
            else if (code == "586")
            {

                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load4);
            }
            else if (code == "369")
            {

                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load5);
            }
            else if (code == "319")
            {

                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load6);
            }
            else if (code == "132")
            {

                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load7);
            }
            else
            {

                Pass.text = null;
            }
        }
    }
}
