using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameObject gameobj; 
    public GameManager gameManager;
    // Start is called before the first frame update
  void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        PlayerPrefs.SetInt(gameobj.name.ToString(), 1);
        Debug.Log(PlayerPrefs.GetInt(gameobj.name.ToString(), 0));
    }
    
    // Start is called before the first frame update
   
   
}
