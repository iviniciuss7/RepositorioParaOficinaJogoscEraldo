using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuWin : MonoBehaviour
{
    public void FecharGame()
    {
        Application.Quit();
    }

    public void CarregarMenu()
    {
        SceneManager.LoadScene(0);
    }
}
