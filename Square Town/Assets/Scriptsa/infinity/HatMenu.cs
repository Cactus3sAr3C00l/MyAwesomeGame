using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatMenu : MonoBehaviour
{
    public GameObject animal, devil, headphones, classic,colorful, MenuPannel, startPannel;
    // Start is called before the first frame update
    public void Start()
    {
       if( PlayerPrefs.GetInt("Czapka", 0) == 1)
        {

            colorful.SetActive(true);

        }
        if(PlayerPrefs.GetInt("Czapka", 0) == 2)
        {

            animal.SetActive(true);

        }
        if(PlayerPrefs.GetInt("Czapka", 0) == 3)
        {

            devil.SetActive(true);

        }
        if(PlayerPrefs.GetInt("Czapka", 0) == 4)
        {

            headphones.SetActive(true);

        }
        if(PlayerPrefs.GetInt("Czapka", 0) == 5)
        {

            classic.SetActive(true);

        }
        


    }
    public void Colorful()
    {
        colorful.SetActive(true);
        MenuPannel.SetActive(false);
        
        PlayerPrefs.SetInt("Czapka", 1);
        startPannel.SetActive(true);
    }
    public void Animal(){
        animal.SetActive(true);
        MenuPannel.SetActive(false);
      
        PlayerPrefs.SetInt("Czapka", 2);
        startPannel.SetActive(true);
    }
    public void Devil()
    {
        devil.SetActive(true);
        MenuPannel.SetActive(false);
   
        PlayerPrefs.SetInt("Czapka", 3);
        startPannel.SetActive(true);


    }
    public void Headphones()
    {
        headphones.SetActive(true);
        MenuPannel.SetActive(false);

        PlayerPrefs.SetInt("Czapka", 4);
        startPannel.SetActive(true);

    }
    public void Classic()
    {
        classic.SetActive(true);
        MenuPannel.SetActive(false);
     
        PlayerPrefs.SetInt("Czapka", 5);
        startPannel.SetActive(true);

    }

    // Update is called once per frame
    
}
