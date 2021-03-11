using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highscore;
    // Update is called once per frame
   
    void Update()
    {
        scoreText.text = (player.position.z - 10).ToString("0");
     
        
    }
    
}
