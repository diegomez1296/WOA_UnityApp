using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using System.IO;
using UnityEngine.SceneManagement;

public class Connection : MonoBehaviour
{
    public bool isLocal = false;
    private string UrlLogin = $"{Constants.MAIN_URL}/api";

    public Text username;
    public Text userpasswd;
    public Text infoText;

    public void Connect()
    {
        StartCoroutine(LogIn());
    }


    private IEnumerator LogIn()
    {
        UnityWebRequest request = UnityWebRequest.Get(UrlLogin + $"/login/{username.text}/{userpasswd.text}");
        yield return request.SendWebRequest();
        string req = request.downloadHandler.text;

        if (request.isHttpError || request.isNetworkError)
        {
            infoText.text = "Connection error";
        }
        else if (req == "false")
        {
            infoText.text = "Invalid username or password";
        }
        else if (req == "true")
        {
            StartCoroutine(GetUserData());
        }
    }

    private IEnumerator GetUserData()
    {
        UnityWebRequest request = UnityWebRequest.Get(UrlLogin + $"/login/{username.text}/getFav");
        yield return request.SendWebRequest();

        if(!(request.isHttpError || request.isNetworkError))
        {
            string[] alcohols = request.downloadHandler.text.Split('|');

            PlayerPrefs.SetString("username", username.text);
            PlayerPrefs.SetInt("alcohols.Length", alcohols.Length - 1);
            for (int i = 0; i < alcohols.Length-1; i++)
            {
                PlayerPrefs.SetString(i + "", alcohols[i]);
            }
            PlayerPrefs.Save();
            ChangeScene("MainScene");
        }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
  
}
