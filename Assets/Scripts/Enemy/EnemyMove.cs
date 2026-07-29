using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform playerTransform;
    [SerializeField] private float enemyMoveSpeed = 5f;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(playerTransform == null)
        {
            return;
        }

        MoveEnemy();
        EnemyFacing();
    }

    private void MoveEnemy()
    {
        Vector3 direction = (playerTransform.position - transform.position).normalized;

        rb.MovePosition(transform.position += direction * enemyMoveSpeed * Time.deltaTime);
    }

    private void EnemyFacing()
    {
        float direction = (transform.position.x - playerTransform.position.x);
        
        if(direction < 0)
        {
            sr.flipX = false;
        }
        else
        {
            sr.flipX = true;
        }
    }
}
