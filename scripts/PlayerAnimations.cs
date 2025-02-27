using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] PlayerMovement player;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (player.IsWalking())
        {
            animator.SetBool("isWalking", true);
        } else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
