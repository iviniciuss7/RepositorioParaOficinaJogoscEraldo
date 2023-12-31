using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text coinText;
    public int scoreCoin; 
    public static GameController instance;
    public GameObject pauseObj;
    private bool gameOverOpen;
    private bool pauseNo;
    public GameObject gameOverObj;
    void Awake()
    {
        instance = this;
        gameOverOpen = false;   
    }

    private void Update()
    {
        PauseGame();
    }

    public void UpdateScore(int value)
    {
        scoreCoin += value;
        coinText.text = scoreCoin.ToString();
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& !gameOverOpen)
        {
            pauseNo = !pauseNo;
            pauseObj.SetActive(pauseNo);
        }
        if (pauseNo)
        {
            Time.timeScale = 0f;
        }

        else
        {
            Time.timeScale = 1f;
        }
    }

    public void RestartGame()
    {
        int chamarCenaAtual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(chamarCenaAtual);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        if (gameOverObj == true)
        {
            Time.timeScale = 0f;
        }

        else
        {
            Time.timeScale = 1f;
        }
    }
    public void GameOver()
    {
        gameOverObj.SetActive(true);
        pauseNo = true;
        gameOverOpen = true;    
    }

}