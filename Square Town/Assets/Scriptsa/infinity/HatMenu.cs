using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HatMenu : MonoBehaviour
{
    public GameObject animal, devil, headphones, classic,colorful, MenuPannel, startPannel;
    // Start is called before the first frame update
    public void Start()
    {
        Check();
        


    }
    void Check()
    {
        if (PlayerPrefs.GetInt("Czapka", 0) == 1)
        {

            colorful.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Czapka", 0) == 2)
        {

            animal.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Czapka", 0) == 3)
        {

            devil.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Czapka", 0) == 4)
        {

            headphones.SetActive(true);

        }
        if (PlayerPrefs.GetInt("Czapka", 0) == 5)
        {

            classic.SetActive(true);

        }
    }
    public void Colorful()
    {
        PlayerPrefs.SetInt("Czapka", 1);
        leave();
    }
    public void Animal(){
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
        MenuPannel.SetActive(false);
      
            startPannel.SetActive(true);
        
        Check();
    }

    // Update is called once per frame
    
}
