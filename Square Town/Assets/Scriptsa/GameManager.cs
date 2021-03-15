using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay=1f;
    public GameObject completeLevelUI;
    public Movement movement;
    public Text money;
    int coincounter;
    public static GameManager inst;
    private void Awake()
    {
        inst = this;

    }
    private void Update()
    {
        coincounter = PlayerPrefs.GetInt("coins", 0);
        money.text = coincounter.ToString();
    }
    public void IncrementCoins()
    {
        coincounter++;
        Debug.Log(coincounter);
        Debug.Log("^");
        PlayerPrefs.SetInt("coins", coincounter);
    }

    public Transform player;
    // Start is called before the first frame update
    
    public void CompleteLevel()
    {
        Debug.Log("Lvl won");
        completeLevelUI.SetActive(true);
        movement.enabled = false;

    }
    private void Start()
    {
        money.text = PlayerPrefs.GetInt("coins", 0).ToString("0");
        coincounter = PlayerPrefs.GetInt("coins", 0);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {


            
           
            gameHasEnded = true;
            Time.timeScale = 1;
            Invoke("Restart", restartDelay);
            Debug.Log("Game Over");
        }

    }
    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public GameObject pausepanel;
    public void PauseGame()
    {
        Debug.Log("pause");
        pausepanel.SetActive(true);
        Time.timeScale = 0;
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
        Time.timeScale = 1;
        Application.Quit();

    }


}
