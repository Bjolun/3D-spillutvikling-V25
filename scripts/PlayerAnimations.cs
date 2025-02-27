using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    // Referanse til spilleren vår slik at vi kan se etter input
    [SerializeField] PlayerMovement player;

    // Trenger vi en referanse til Animator komponent
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // På hver frame ønsker vi å se om noe er trykket på
    private void Update()
    {
        // Hvis WASD er trykket på, setter vi isWalking til true. (se PlayerMovement for å se IsWalking metoden)
        if (player.IsWalking())
        {
            animator.SetBool("isWalking", true);
        } 
        // Hvis INGEN knapper er trykket på, så settes isWalking til false.
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
