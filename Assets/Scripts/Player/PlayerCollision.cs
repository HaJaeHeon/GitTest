using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    PlayerAnimator animator;
    [SerializeField] private float currentTimer;
    [SerializeField] private float ImmotalTime = 1f;

    private void Awake()
    {
        animator = GetComponent<PlayerAnimator>();
        currentTimer = 0f;
    }

    private void Update()
    {
        currentTimer += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && currentTimer > ImmotalTime)
        {
            currentTimer = 0f;
            animator.AniTrigger("Hit");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && currentTimer > ImmotalTime)
        {
            currentTimer = 0f;
            animator.AniTrigger("Hit");
        }
    }
}
