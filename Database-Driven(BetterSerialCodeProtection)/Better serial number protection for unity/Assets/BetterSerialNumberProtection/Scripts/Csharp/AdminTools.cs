using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdminTools : MonoBehaviour
{
    public InputField serialnumberToAdd;
    public InputField HowManyRandom;

    public InputField serialToEdit;
    public InputField newValidNumber;

    public string createPhpUrl;
    public string changeValidPhpUrl;
    private string output;
    [Header("PopUps")]
    public GameObject checking;

    

    public void AddKey()
    {
        checking.SetActive(true);
        StartCoroutine(AddKeyToServer());
    }

    IEnumerator AddKeyToServer()
    {
        WWW www = new WWW(createPhpUrl + "/" + serialnumberToAdd.text);

        while (!www.isDone && string.IsNullOrEmpty(www.error))
        {
            yield return null;
        }

        if (string.IsNullOrEmpty(www.error)) output = www.text;
        else Debug.LogWarning(www.error);
        Results();
    }

    void Results()
    {
        checking.SetActive(false);
        Debug.Log(output);
        serialnumberToAdd.text = "";
        HowManyRandom.text = "";
        serialToEdit.text = "";
        newValidNumber.text = "";
    }

    public void AddRandom()
    {
        int hmr = int.Parse(HowManyRandom.text);
        checking.SetActive(true);
        for (int x = 0; x < hmr; x++)
        {
            string chr = "QAZXSWEDCVFRTGBNHYUJMKILOP1234567890";
            string finalKey = "";
            for (int i = 0; i < 16; i++)
            {
                char c = chr[Random.Range(0, chr.Length)];
                finalKey += c;
            }
            StartCoroutine(AddRandomToServer(finalKey));
        }
    }

    IEnumerator AddRandomToServer(string key)
    {
        WWW www = new WWW(createPhpUrl + "/" + key);

        while (!www.isDone && string.IsNullOrEmpty(www.error))
        {
            yield return null;
        }

        if (string.IsNullOrEmpty(www.error)) output = www.text;
        else Debug.LogWarning(www.error);
        Results();
    }

    public void ChangeValid()
    {
        checking.SetActive(true);
        StartCoroutine(ChangeValidSrv());
    }

    IEnumerator ChangeValidSrv()
    {
        WWW www = new WWW(changeValidPhpUrl + "/" + newValidNumber.text + "/" + serialToEdit.text);

        while (!www.isDone && string.IsNullOrEmpty(www.error))
        {
            yield return null;
        }

        if (string.IsNullOrEmpty(www.error)) output = www.text;
        else Debug.LogWarning(www.error);
        Results();
    }
}
