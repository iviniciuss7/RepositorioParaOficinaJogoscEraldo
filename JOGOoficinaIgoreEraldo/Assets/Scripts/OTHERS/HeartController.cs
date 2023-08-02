using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeartController : MonoBehaviour
{
    public int vida;
    public int vidaMaxima;

    public Image[] corasao;
    public Sprite cheio;
    public Sprite vazio;
    
    
    
    
    void Update()
    {
        LifeLogic();
        DeadState();
    }

    void LifeLogic()
    {
        if (vida > vidaMaxima)
        {
            vida=vidaMaxima;
        }
        
        for (int i = 0; i < corasao.Length; i++)
        {
            if(i<vida){
                corasao[i].sprite = cheio;
            }
            else
            {
                corasao[i].sprite = vazio;
            }
            
            if(i < vidaMaxima)
            {
                corasao[i].enabled = true;
            }
            else
            {
                corasao[i].enabled = false;
            }
        }
    }
    void DeadState()
    {
        if(vida <= 0)
        {
            GetComponent<PlayerWalk>().enabled = false;
            Destroy(gameObject, 0.5f); 
            GameController.instance.GameOver();
        }
    }
    
}
