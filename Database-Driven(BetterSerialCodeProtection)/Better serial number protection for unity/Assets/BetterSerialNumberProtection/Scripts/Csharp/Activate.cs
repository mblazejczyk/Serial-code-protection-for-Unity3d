using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Activate : MonoBehaviour
{
    public InputField nameInput;
    public InputField numberInput;
    public string revicePhpUrl;
    private string output;
    [Header("PopUps")]
    public GameObject noNameValid;
    public GameObject nameCorrect;
    public GameObject wrongName;
    public GameObject noLongerValid;
    public GameObject wrongCode;
    public GameObject checking;


    private void Start()
    {
        if (PlayerPrefs.GetInt("activatedBefore") == 1)
        {
            checking.SetActive(true);
            StartCoroutine(checkStored());
        }
    }
    IEnumerator checkStored()
    {
        WWW www = new WWW(revicePhpUrl + "/" + PlayerPrefs.GetString("nameStored") + "/" + PlayerPrefs.GetString("keyStored"));

        while (!www.isDone && string.IsNullOrEmpty(www.error))
        {
            yield return null;
        }

        if (string.IsNullOrEmpty(www.error)) output = www.text;
        else Debug.LogWarning(www.error);
        
        if(output == "inputNameCorrect" || output == "noName")
        {
            GoToGame();
        }
        else
        {
            Results();
        }
    }

    public void Submit()
    {
        output = "";
        checking.SetActive(true);
        StartCoroutine(CheckKey());
    }

    IEnumerator CheckKey()
    {
        WWW www = new WWW(revicePhpUrl + "/" + nameInput.text + "/" + numberInput.text);

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
        switch (output)
        {
            case "noName":
                noNameValid.SetActive(true);
                PlayerPrefs.SetString("nameStored", nameInput.text);
                PlayerPrefs.SetString("keyStored", numberInput.text);
                PlayerPrefs.SetInt("activatedBefore", 1);
                break;
            case "inputNameCorrect":
                nameCorrect.SetActive(true);
                PlayerPrefs.SetString("nameStored", nameInput.text);
                PlayerPrefs.SetString("keyStored", numberInput.text);
                PlayerPrefs.SetInt("activatedBefore", 1);
                break;
            case "wrongName":
                wrongName.SetActive(true);
                break;
            case "notValid":
                noLongerValid.SetActive(true);
                break;
            case "wrongCode":
                wrongCode.SetActive(true);
                break;
        }
        nameInput.text = "";
        numberInput.text = "";
    }

    public void GoToGame()
    {
        SceneManager.LoadScene(1);
    }
}
