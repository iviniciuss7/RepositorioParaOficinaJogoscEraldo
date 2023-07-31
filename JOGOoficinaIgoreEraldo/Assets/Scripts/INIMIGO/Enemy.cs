using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Tempo e velocidade")]
    public float speed, walktime, timer;
    
    [Header("Vidas")]
    [SerializeField] int health;

    [Header("Componentes")]
    [SerializeField] Rigidbody2D rig;

    [Header("Booleanos")]
    bool walkRight; 


    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer >= walktime)
        {
            walkRight = !walkRight;
            timer = 0f;
        }
        if (walkRight)
        {
            transform.eulerAngles = new Vector2(0, 180);
            rig.velocity = Vector2.right * speed;
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 0);
            rig.velocity = Vector2.left * speed;
        }
    }

    public void takeDamage(int dmg)
    {
        health -= dmg;

        if (health <= 0)
        {

            Destroy(gameObject);
        }
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Teste");
            collision.gameObject.GetComponent<PlayerWalk>().Damage(1);
        }
    }*/
}
