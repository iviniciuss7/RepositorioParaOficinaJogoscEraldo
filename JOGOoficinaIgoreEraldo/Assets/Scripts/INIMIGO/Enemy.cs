using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float chasingSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] float distance;
    [SerializeField] float distancePlayer;
    bool isRight = true;
    [SerializeField] LayerMask playerLayer;

    [SerializeField] Transform groundCheck;

    void Update()
    {
        Move();

    
    }

    private void Move()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        RaycastHit2D ground = Physics2D.Raycast(groundCheck.position, Vector2.down, distance);

        if (ground.collider == false)
        {
            if (isRight == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                isRight = true;
            }
        }
    }
    void Chasing()
    {
        RaycastHit2D playerhit = Physics2D.Raycast(transform.position, transform.forward, distancePlayer, playerLayer);
        if(playerhit.collider == false)
        {
            return;
        }

    }

}
