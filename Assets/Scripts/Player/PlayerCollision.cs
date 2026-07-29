using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    PlayerAnimator animator;

    private void Awake()
    {
        animator = GetComponent<PlayerAnimator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            animator.AniTrigger("Hit");
        }
    }
}
