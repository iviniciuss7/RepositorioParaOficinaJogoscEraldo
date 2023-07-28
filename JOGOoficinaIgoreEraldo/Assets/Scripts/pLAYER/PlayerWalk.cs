using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] float velocity;
    [SerializeField] float forcadoPulo;
    [SerializeField] Rigidbody2D rigP;
    Vector3 angleLeft;

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

        rigP.velocity = new Vector2(movement * velocity, rigP.velocity.y);

        if (movement > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
        else if (movement < 0)
            transform.eulerAngles = angleLeft;
    }
    void Pulo()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!noAr)
            {
                rigP.velocity = new Vector2(rigP.velocity.x, forcadoPulo);
                puloDuplo = true;
                noAr = true;
            }
            else 
            {
                if (puloDuplo)
                {
                    rigP.velocity = new Vector2(rigP.velocity.x, forcadoPulo * 2);
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
        }
    }
}

