using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private Vector2 playerInput;
    [SerializeField] private float playerMoveSpeed =5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private PlayerAnimator animator;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<PlayerAnimator>();
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

    //input system을 이용해 value 값 받아오기
    public void OnMove(InputValue value)
    {
        playerInput = value.Get<Vector2>();
    }

    //input value 받아서 rigidbody2D를 이용한 이동 및 이동 애니메이션
    private void PlayerMove()
    {
        rb.MovePosition(transform.position += (Vector3)playerInput * playerMoveSpeed * Time.deltaTime);

        if(playerInput != Vector2.zero)
        {
            animator.AniSetFloat("PlayerMoveSpeed", 1f);
        }
        else
        {
            animator.AniSetFloat("PlayerMoveSpeed", 0f);
        }
    }

    //sprite가 플레이어 이동 방향으로 바라보게끔
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
