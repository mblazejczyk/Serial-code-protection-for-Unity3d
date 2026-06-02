using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Protect : MonoBehaviour {
    [Header("Edit script to fill important informations!")]
    public string url = "";
    private string output;
    [Tooltip("What ID has next scene?")]
    public int nextScene = 0;
    [Tooltip("Put here InputField where player will enter code")]
    public InputField KeyInput;

    IEnumerator Start()
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            output = www.text;
        }
        foreach (var key in output.Split(' '))
        {
            if(key == Encryptor.DeEncrypt( PlayerPrefs.GetString("MainGameSave")))
            {
                SceneManager.LoadScene(nextScene);
            }
        }

    }

    public void Activate()
    {
        foreach (var key in output.Split(' '))
        {
            if (key == KeyInput.text)
            {
                PlayerPrefs.SetString("MainGameSave",Encryptor.Encrypt( KeyInput.text));
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}