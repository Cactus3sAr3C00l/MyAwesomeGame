using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Coins : MonoBehaviour
{
    int coincounter;
    public float Speed = 90f;
  
    
  

    // Start is called before the first frame update
    void Start()
    {
        coincounter = PlayerPrefs.GetInt("coins", 0);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Player")
         if (SceneManager.GetActiveScene().buildIndex == 1) { 
            GameManagerInf.inst.IncrementCoins();
           
        }
            else GameManager.inst.IncrementCoins();



        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Speed * Time.deltaTime);
    }
}
