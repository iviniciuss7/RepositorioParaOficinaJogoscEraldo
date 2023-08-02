using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] Animator animator;
    private PlayerWalk playerWalkScript;
    public PlayerAttack PlayerAttack;  

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerWalkScript = GetComponent<PlayerWalk>();
    }

    private void Update()
    {
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {

        float movement = Input.GetAxis("Horizontal");

        if (playerWalkScript.noAr)
        {
            animator.SetInteger("Transition", 2);
        }
        else if (movement != 0)
        {
            animator.SetInteger("Transition", 1);
        }
        else
        { 
            animator.SetInteger("Transition", 0);
        }

    }
    public void Attack()
    {
        animator.SetTrigger("Tiro");
    }

    public void Damage()
    {
        animator.SetTrigger("Damage");
    }
}
