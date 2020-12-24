using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_script : MonoBehaviour
{
    [SerializeField] float start_Time = 3600f;
    [SerializeField] Text Timer_Text;

    float timer;

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    private IEnumerator Countdown()
    {
        timer = start_Time;

        do
        {
            timer -= Time.deltaTime;
            format_text();
            yield return null;
        }
        while (timer > 0);
    }

    private void format_text()
    {
        int M = (int)(timer / 60) % 60;
        int s = (int)(timer % 60);

        Timer_Text.text = "";
        Timer_Text.text += M + ":" + s;       
    }

}
