using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDoPlayer : MonoBehaviour
{
    public int health = 3;
    void Start()
    {
        GameController.instance.UpdateLives(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int dmg)
    {
        health -= dmg;
        
        if (health <= 0)
        {
            //chamar gameover
        }
    }
}
