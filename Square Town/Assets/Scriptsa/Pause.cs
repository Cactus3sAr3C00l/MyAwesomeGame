using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject animal, devil, headphones, classic, StartPannel, rainbow;
    public GameObject pausepanel, HatPannel;
    public void PauseGame()
    {
        Debug.Log("pause");
        pausepanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void GoToHatMenu()
    {
        Time.timeScale = 0;
        animal.SetActive(false);
        devil.SetActive(false);
        headphones.SetActive(false);
        animal.SetActive(false);
        classic.SetActive(false);
        rainbow.SetActive(false);

        HatPannel.SetActive(true);
        pausepanel.SetActive(false);
    }
    public void GoToHatMenu2()
    {
        Time.timeScale = 0;
        animal.SetActive(false);
        devil.SetActive(false);
        headphones.SetActive(false);
        animal.SetActive(false);
        classic.SetActive(false);
        rainbow.SetActive(false);
        HatPannel.SetActive(true);
        StartPannel.SetActive(false);
    }
   
    public void ResumeGame()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void PreviousLvl()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;

    }
    public void NextLvl()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
    public void Quit()
    {
        Debug.Log("Quit");
        Time.timeScale = 1;
        Application.Quit();

    }



}
