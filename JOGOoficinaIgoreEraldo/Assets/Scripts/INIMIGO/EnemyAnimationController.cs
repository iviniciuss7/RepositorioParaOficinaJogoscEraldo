using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationController : MonoBehaviour
{
    [SerializeField] Animator anim;

    private void Update()
    {
        anim.SetInteger("Transition", 1);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player_bullet"))
        {
            anim.SetTrigger("Hit");
        }
    }
}
