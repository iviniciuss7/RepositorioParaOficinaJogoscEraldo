using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    float fireRate = 0.3f;
    float nextFire;
    [SerializeField] Animator anim;
    [SerializeField] GameObject tiro;
    [SerializeField] Transform spawner;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.G) && Time.time > nextFire)
        {
            anim.SetInteger("Transition", 3);
            nextFire = Time.time + fireRate;
            GameObject tempNote = Instantiate(tiro, spawner.position, spawner.rotation);
        }
    }
}
