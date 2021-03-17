using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatmenu2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hatPannel;
    // Update is called once per frame
   public void HatMenu()
    {
        hatPannel.SetActive(true);
    }
    public void Colorful()
    {
        PlayerPrefs.SetInt("Czapka", 1);
        leave();
    }
    public void Animal()
    {
        PlayerPrefs.SetInt("Czapka", 2);
        leave();
    }
    public void none()
    {

        PlayerPrefs.SetInt("Czapka", 0);
        leave();
    }
    public void Devil()
    {
        PlayerPrefs.SetInt("Czapka", 3);
        leave();


    }
    public void Headphones()
    {
        PlayerPrefs.SetInt("Czapka", 4);
        leave();

    }
    public void Classic()
    {
        PlayerPrefs.SetInt("Czapka", 5);
        leave();


        
    }
   public void leave()
    {
        hatPannel.SetActive(false);
    }
}
