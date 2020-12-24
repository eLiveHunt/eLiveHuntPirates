using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code_Panel : MonoBehaviour
{
    public GameObject CodePanel;
    public GameObject Open_boutton;

    public void close_panel()
    {
        CodePanel.gameObject.SetActive(false);
        Open_boutton.gameObject.SetActive(true);
    }

    public void open_panel()
    {
        CodePanel.gameObject.SetActive(true);
        Open_boutton.gameObject.SetActive(false);
    }

	// Use this for initialization
	void Start ()
    {
        CodePanel.gameObject.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
