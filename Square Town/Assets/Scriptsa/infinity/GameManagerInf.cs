using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManagerInf : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI, hatpannel;
    public Movement movement;
    public Text highscore;
    public Text money;
   public int coincounter;
    public static GameManagerInf inst;
    public Transform player;
    int cost;
    public HatMenu var;
    // Start is called before the first frame update
    private void Start()
    {

        highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
        money.text = PlayerPrefs.GetInt("coins",0).ToString("0");
        coincounter = PlayerPrefs.GetInt("coins", 0);

    }
    private void Awake()
    {
        inst = this;
        
    }
    public void IncrementCoins()
    {
        coincounter++;
        Debug.Log(coincounter);
        Debug.Log("^");
        PlayerPrefs.SetInt("coins", coincounter);
    }
    public void CompleteLevel()
    {
        Debug.Log("Lvl won");
        completeLevelUI.SetActive(true);
        movement.enabled = false;

    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {



            Debug.Log(int.Parse(highscore.text));
            if (player.position.z + 129 > int.Parse(highscore.text))
            {
                PlayerPrefs.SetFloat("HighScore", player.position.z + 129);


                highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");

                PlayerPrefs.Save();
            }
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
    private void Update()
    {
       
            coincounter = PlayerPrefs.GetInt("coins", 0); 
            PlayerPrefs.SetInt("coins", coincounter);
            money.text = PlayerPrefs.GetInt("coins", 0).ToString();
        
    }
   


}
