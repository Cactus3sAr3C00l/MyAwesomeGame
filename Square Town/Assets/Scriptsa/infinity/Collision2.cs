using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision2 : MonoBehaviour
{
    public Transform player;
    public Movement movement;
    public GameObject hat;
    public Vector3 distance;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name != "Ground" && collisionInfo.collider.name != "hat" )
        {
            movement.enabled = false;
            
           
            gameObject.GetComponent<BoxCollider>().enabled = true;


            FindObjectOfType<GameManagerInf>().EndGame();

        }

    }
}
