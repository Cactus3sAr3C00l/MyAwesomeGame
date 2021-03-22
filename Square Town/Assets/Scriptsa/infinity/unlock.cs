using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlock : MonoBehaviour
{
    public GameObject gameobj;
    int temp;
    public Text money;
    void Start()
    {
        string n = gameobj.ToString();
        if(PlayerPrefs.GetInt(n, 0) == 1)
        {
            gameobj.SetActive(false);
        }
    }
    public void Unlock()
    {
        if (PlayerPrefs.GetInt("coins",0)  >= 200 )
        { 
            string n = gameobj.ToString();
            gameobj.SetActive(false);
            DontDestroyOnLoad(gameobj);
            PlayerPrefs.SetInt(n, 1);
        }
    }
    public void UnlockPlatform()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 320)
        {
            string n = gameobj.ToString();
            gameobj.SetActive(false);
            DontDestroyOnLoad(gameobj);
            PlayerPrefs.SetInt(n, 1);
        }
    }
}
