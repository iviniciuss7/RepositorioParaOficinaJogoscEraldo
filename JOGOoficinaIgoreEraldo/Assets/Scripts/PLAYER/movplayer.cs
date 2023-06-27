using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movplayer : MonoBehaviour
{
    public float forcadoPulo;
    public float speed;
    private Animator anim;
    private Rigidbody2D rig;
    public bool noAr;
    public bool puloDuplo;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movimentacao();
        Pulo();
    }

    void Movimentacao()
    {
        float movimento = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(movimento * speed, rig.velocity.y);

        if (movimento > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (movimento < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
    
    void Pulo()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!noAr)
            {
                rig.AddForce(new Vector2(0, forcadoPulo), ForceMode2D.Impulse);
                puloDuplo = true;
                noAr = true;
            }
            
        
            else
            {
                rig.AddForce(new Vector2(0, forcadoPulo * 2), ForceMode2D.Impulse);
                puloDuplo = false;
            }
        }
    }    
        void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 3)
        {
            noAr = false;
        }
    }
}
