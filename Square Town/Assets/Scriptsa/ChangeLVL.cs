using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLVL : MonoBehaviour
{
    public GameObject gameobj;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(PlayerPrefs.GetInt(gameobj.name.ToString(), 0));
        Debug.Log(gameobj.name.ToString());
        if (PlayerPrefs.GetInt(gameobj.name.ToString(), 0) == 1)
        {
            gameobj.SetActive(true);
        }
    }
   public void Nextlvl()
    {
        SceneManager.LoadScene(int.Parse(gameobj.name.ToString())+1);
    }
  

}
