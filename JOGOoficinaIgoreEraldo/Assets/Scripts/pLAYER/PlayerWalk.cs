using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] float velocity;
    [SerializeField] Rigidbody2D rigP;
    Vector3 angleLeft;

    private void Start()
    {
        angleLeft = new Vector3(0, 180, 0);
    }
    void Update()
    {
        Move();
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
}
