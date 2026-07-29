using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private Vector2 playerInput;
    [SerializeField] private float playerMoveSpeed =5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        
    }
    private void Start()
    {
        
    }

    private void Update()
    {
        PlayerMove();
        PlayerFacing(playerInput);
    }

    public void OnMove(InputValue value)
    {
        playerInput = value.Get<Vector2>();
    }

    private void PlayerMove()
    {
        rb.MovePosition(transform.position += (Vector3)playerInput * playerMoveSpeed * Time.deltaTime);

        if(playerInput != Vector2.zero)
        {
            animator.SetFloat("PlayerMoveSpeed", 1f);
        }
        else
        {
            animator.SetFloat("PlayerMoveSpeed", 0f);
        }
    }
    public void PlayerFacing(Vector2 value)
    {
        if(value.x < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}
