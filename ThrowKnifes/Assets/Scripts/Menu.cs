using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject menupause;
    public GameObject restartb;
    public GameObject quitb;
    public GameObject resumeb;
    public GameObject pauseb;

    
    public void Restart()
    {
        Time.timeScale = 1;
        pauseb.SetActive(true);
        menupause.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Start");
        print("quit");
    }

    public void Resume()
    {
        menupause.SetActive(false);
        pauseb.SetActive(true);
        Time.timeScale = 1;
    }


    public void Pause()
    {
        Time.timeScale = 0;
        pauseb.SetActive(false);
        menupause.SetActive(true);
        print("pause");
    }
}
