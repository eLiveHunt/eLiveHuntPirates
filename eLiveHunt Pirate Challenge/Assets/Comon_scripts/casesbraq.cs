using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class casesbraq : MonoBehaviour
{
    public Image[] correct;
    public Image[] empty;
    public int joueur;
    int i = 0;

    public void correct_case(int corr)
    {
        if (correct[corr].enabled == false)
            correct[corr].enabled = true;
        else if (correct[corr].enabled == true)
            correct[corr].enabled = false;
    }

    public void Empty(int spot)
    {
        if (empty[spot].enabled == false)
            empty[spot].enabled = true;
        else if (empty[spot].enabled == true)
            empty[spot].enabled = false;
    }

    public void vide_j1()
    {
        while (i < 3)
        {
            correct[i].enabled = false;
            i++;
        }

        i = 0;

        while (i < 39)
        {
            empty[i].enabled = false;
            i++;
        }
    }

    public void vide_j2()
    {
        i = 0;

        correct[0].enabled = false;
        correct[1].enabled = false;
        
        while (i < 40)
        {
            empty[i].enabled = false;
            i++;
        }
    }

    public void vide_j3()
    {
        i = 0;

        correct[0].enabled = false;
        correct[1].enabled = false;

        while (i < 40)
        {
            empty[i].enabled = false;
            i++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (joueur == 1)
            vide_j1();
        else if (joueur == 2)
            vide_j2();
        else if (joueur == 3)
            vide_j3();
    }
}
