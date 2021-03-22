using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinspending : MonoBehaviour
{
    // Start is called before the first frame update
    int cost;
    int coincounter;

    public void buyHat()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 200)
        {
            Cost();
            coincounter = PlayerPrefs.GetInt("coins", 0);
            coincounter = coincounter - cost;
            PlayerPrefs.SetInt("coins", coincounter);

        }    }

    public void buyPlatform()
    {
        if (PlayerPrefs.GetInt("coins", 0) >= 320)
        {
            cost = 320;
            coincounter = PlayerPrefs.GetInt("coins", 0);
            coincounter = coincounter - cost;
            PlayerPrefs.SetInt("coins", coincounter);

        }
    }

    void Cost()
    {
        cost = 200;
    }
}
