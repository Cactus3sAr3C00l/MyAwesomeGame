using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision2 : MonoBehaviour
{
    public Transform player;
    public Movement movement;
  
   
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name != "Ground")
        {
            movement.enabled = false;


           
            FindObjectOfType<GameManager>().EndGame();
            
        }

    }
}
