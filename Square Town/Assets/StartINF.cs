using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartINF : MonoBehaviour
{
    public GameObject startpannel, pausebutton;
    public Movement movement;
    // Start is called before the first frame update
    void Start()
    {

        movement.enabled = false;
    }

    // Update is called once per frame
    public void StartClick()
    {
        movement.enabled = true;
        Time.timeScale = 1;
        startpannel.SetActive(false);
        pausebutton.SetActive(true);
    }
}
