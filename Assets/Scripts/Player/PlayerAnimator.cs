using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void AniTrigger(string clipName)
    {
        animator.SetTrigger(clipName);
    }
    public void AniSetFloat(string clipName, float value)
    {
        animator.SetFloat(clipName, value);
    }
}
