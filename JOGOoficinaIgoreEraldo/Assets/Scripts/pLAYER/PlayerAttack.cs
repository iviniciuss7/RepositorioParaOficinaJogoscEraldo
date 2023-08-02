using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    float fireRate = 0.3f;
    public float nextFire;
    [SerializeField] Animator anim;
    [SerializeField] GameObject tiro;
    [SerializeField] Transform spawner;
    private PlayerAnimationController playerAnimationController;
    private void Awake()
    {
        playerAnimationController = GetComponent<PlayerAnimationController>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.G) && Time.time > nextFire)
        {
            playerAnimationController.Attack();
            nextFire = Time.time + fireRate;
            GameObject tempNote = Instantiate(tiro, spawner.position, spawner.rotation);
        }
    }
}
