using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    PlayerInfo playerInfo;
    PlayerAnimator animator;
    [SerializeField] private float currentTimer;
    [SerializeField] private float invincibleTime = 1f;

    private void Awake()
    {
        playerInfo = GetComponent<PlayerInfo>();
        animator = GetComponent<PlayerAnimator>();
        currentTimer = 0f;
    }

    private void Update()
    {
        currentTimer += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && currentTimer > invincibleTime)
        {
            currentTimer = 0f;
            animator.AniTrigger("Hit");
            playerInfo.TakeDamage(10);
            //Debug.Log("EnterHit");
        }

        if(collision.gameObject.CompareTag("Item"))
        {
            collision.GetComponent<Item>().UseItem(gameObject);
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && currentTimer > invincibleTime)
        {
            currentTimer = 0f;
            animator.AniTrigger("Hit");
            playerInfo.TakeDamage(10);
            //Debug.Log("StayHit");
        }
    }
}
