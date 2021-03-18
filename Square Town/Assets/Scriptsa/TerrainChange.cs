using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainChange : MonoBehaviour
{
    public GameObject o1,o2,o3,o4;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Terrain", 2)== 1)
        {
            o1.SetActive(true);
            o2.SetActive(false);
            o3.SetActive(false);
            o4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Terrain", 2) == 2)
        {
            o1.SetActive(false);
            o2.SetActive(true);
            o3.SetActive(false);
            o4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Terrain", 2) == 3)
        {
            o1.SetActive(false);
            o2.SetActive(false);
            o3.SetActive(true);
            o4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Terrain", 2) == 4)
        {
            o1.SetActive(false);
            o2.SetActive(false);
            o3.SetActive(false);
            o4.SetActive(true);
        }

    }
    public void change1()
    {
        o1.SetActive(true);
        o2.SetActive(false);
        o3.SetActive(false);
        o4.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("Terrain", 1);

    }
    public void change2()
    {
        o1.SetActive(false);
        o2.SetActive(true);
        o3.SetActive(false);
        o4.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("Terrain", 2);

    }
    public void change3()
    {
        o1.SetActive(false);
        o2.SetActive(false);
        o3.SetActive(true);
        o4.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("Terrain", 3);
    }
    public void change4()
    {
        o1.SetActive(false);
        o2.SetActive(false);
        o3.SetActive(false);
        o4.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("Terrain", 4);
    }
}
