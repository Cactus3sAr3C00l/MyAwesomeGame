using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Text money;
    // Start is called before the first frame update

    public GameObject pannel;
    public void setPannel()
    {
        pannel.SetActive(true);
    }
    public void leavePannel()
    {
        pannel.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
    public void StartGame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
    public void Update()
    {
        money.text = PlayerPrefs.GetInt("coins", 0).ToString();
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
