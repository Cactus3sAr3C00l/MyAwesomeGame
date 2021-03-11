using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        {
            GameManagerInf.inst.IncrementCoins();
           
        }



        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Speed * Time.deltaTime);
    }
}
