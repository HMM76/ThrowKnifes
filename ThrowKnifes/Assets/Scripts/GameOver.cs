using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject restartb;
    public GameObject quitb;
    public GameObject pauseb;
    public GameObject gameover;

    
    public void Restart()
    {
        Time.timeScale = 1;
        pauseb.SetActive(true);
        gameover.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Start");
        print("quit");
    }


    public void GameOveer()
    {
        gameover.SetActive(true);
        pauseb.SetActive(false);
        Time.timeScale = 0;
    }
}
