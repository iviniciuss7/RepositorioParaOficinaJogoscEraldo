using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [Header("Fisica")]
    [SerializeField] float velocity;
    [SerializeField] float forcadoPulo;
    public float movementInstance;

    [Header("Componentes")]
    [SerializeField] Rigidbody2D rigP;
    public Animator anim;
    [SerializeField] AudioSource sound;
    Vector3 angleLeft;
    [Header("Booleanos")]
    public bool noAr;
    public bool puloDuplo;

    private void Start()
    {
        angleLeft = new Vector3(0, 180, 0);
    }
    void Update()
    {
        Move();
        Pulo();
    }
    private void Move()
    {
        float movement = Input.GetAxis("Horizontal");
        movementInstance = movement;

        rigP.velocity = new Vector2(movement * velocity, rigP.velocity.y);

        
        if (movement > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
        else if (movement < 0)
        {
            transform.eulerAngles = angleLeft;
        }
    }
    void Pulo()
    {
        if (Input.GetButtonDown("Jump"))
        { 
            if (!noAr)
            {
                sound.Play();
                rigP.velocity = new Vector2(rigP.velocity.x, forcadoPulo);
                puloDuplo = true;
                noAr = true;
            }
            else 
            {
                if (puloDuplo)
                {
                    sound.Play();
                    rigP.velocity = new Vector2(rigP.velocity.x, forcadoPulo);
                    puloDuplo = false;
                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 6)
        {
            noAr = false;
            transform.parent = col.transform;
        }

        if (col.gameObject.layer == 9)
        {
            GameController.instance.GameOver();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.layer == 6)
        {
            transform.parent = null;
        }
    }
}

