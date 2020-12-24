using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;

public class LoadAssetBundle : MonoBehaviour
{

    string url = "https://drive.google.com/uc?export=download&id=1dzHWsqpmWS8aqVhbTb4YlK4k7r0IXgkS";
    private float progress;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WWWRoutine());
    }

    private IEnumerator WWWRoutine()
    {
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(url);

        var asynOperation = www.SendWebRequest();

        while (!www.isDone)
        {
            progress = asynOperation.progress;
            yield return null;
        }

        progress = 1f;

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log("empty string");
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene("joueur_sheraz");
    }
}
